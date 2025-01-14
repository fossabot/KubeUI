using System.Reflection;
using System.Text;
using k8s;
using k8s.Models;
using YamlDotNet.Core;
using YamlDotNet.Core.Events;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;
using YamlDotNet.System.Text.Json;

namespace KubeUI.Client.Serialization;

/// <summary>
/// This is a utility class that helps you load objects from YAML files.
/// </summary>
public static class KubernetesYaml
{
    public static readonly IDeserializer Deserializer =
        new DeserializerBuilder()
            .WithNamingConvention(CamelCaseNamingConvention.Instance)
            .WithTypeConverter(new IntOrStringYamlConverter())
            .WithTypeConverter(new ByteArrayStringYamlConverter())
            .WithTypeConverter(new ResourceQuantityYamlConverter())
            .WithTypeConverter(new SystemTextJsonYamlTypeConverter())
            .WithTypeInspector(x => new SystemTextJsonTypeInspector(x))
            .WithAttemptingUnquotedStringTypeDeserialization()
            .IgnoreUnmatchedProperties()
            .Build();

    public static readonly IValueSerializer Serializer =
        new SerializerBuilder()
            .DisableAliases()
            .WithNamingConvention(CamelCaseNamingConvention.Instance)
            .WithTypeConverter(new IntOrStringYamlConverter())
            .WithTypeConverter(new ByteArrayStringYamlConverter())
            .WithTypeConverter(new ResourceQuantityYamlConverter())
            .WithEventEmitter(e => new StringQuotingEmitter(e))
            .WithEventEmitter(e => new FloatEmitter(e))
            .WithTypeConverter(new SystemTextJsonYamlTypeConverter(true))
            .WithTypeInspector(x => new SystemTextJsonTypeInspector(x))
            .WithTypeInspector(x => new SortedTypeInspector(x))
            .ConfigureDefaultValuesHandling(DefaultValuesHandling.OmitNull)
            .BuildValueSerializer();

    private static readonly IDictionary<string, Type> ModelTypeMap = typeof(KubernetesEntityAttribute).Assembly
        .GetTypes()
        .Where(t => t.GetCustomAttributes(typeof(KubernetesEntityAttribute), true).Any())
        .ToDictionary(
            t =>
            {
                var attr = (KubernetesEntityAttribute)t.GetCustomAttribute(
                    typeof(KubernetesEntityAttribute), true);
                var groupPrefix = string.IsNullOrEmpty(attr.Group) ? "" : $"{attr.Group}/";
                return $"{groupPrefix}{attr.ApiVersion}/{attr.Kind}";
            },
            t => t);

    private class ByteArrayStringYamlConverter : IYamlTypeConverter
    {
        public bool Accepts(Type type)
        {
            return type == typeof(byte[]);
        }

        public object ReadYaml(IParser parser, Type type, ObjectDeserializer rootDeserializer)
        {
            if (parser?.Current is Scalar scalar)
            {
                try
                {
                    if (string.IsNullOrEmpty(scalar.Value))
                    {
                        return null;
                    }

                    return Encoding.UTF8.GetBytes(scalar.Value);
                }
                finally
                {
                    parser.MoveNext();
                }
            }

            throw new InvalidOperationException(parser.Current?.ToString());
        }

        public void WriteYaml(IEmitter emitter, object? value, Type type, ObjectSerializer serializer)
        {
            var obj = (byte[])value;
            emitter?.Emit(new Scalar(Encoding.UTF8.GetString(obj)));
        }
    }

    /// <summary>
    /// Load a collection of objects from a stream asynchronously
    ///
    /// caller is responsible for closing the stream
    /// </summary>
    /// <param name="stream">
    /// The stream to load the objects from.
    /// </param>
    /// <param name="typeMap">
    /// A map from apiVersion/kind to Type. For example "v1/Pod" -> typeof(V1Pod). If null, a default mapping will
    /// be used.
    /// </param>
    /// <returns>collection of objects</returns>
    public static async Task<List<object>> LoadAllFromStreamAsync(Stream stream, IDictionary<string, Type> typeMap = null)
    {
        var reader = new StreamReader(stream);
        var content = await reader.ReadToEndAsync().ConfigureAwait(false);
        return LoadAllFromString(content, typeMap);
    }

    /// <summary>
    /// Load a collection of objects from a file asynchronously
    /// </summary>
    /// <param name="fileName">The name of the file to load from.</param>
    /// <param name="typeMap">
    /// A map from apiVersion/kind to Type. For example "v1/Pod" -> typeof(V1Pod). If null, a default mapping will
    /// be used.
    /// </param>
    /// <returns>collection of objects</returns>
    public static async Task<List<object>> LoadAllFromFileAsync(string fileName, IDictionary<string, Type> typeMap = null)
    {
        using (var fileStream = File.OpenRead(fileName))
        {
            return await LoadAllFromStreamAsync(fileStream, typeMap).ConfigureAwait(false);
        }
    }

    /// <summary>
    /// Load a collection of objects from a string
    /// </summary>
    /// <param name="content">
    /// The string to load the objects from.
    /// </param>
    /// <param name="typeMap">
    /// A map from apiVersion/kind to Type. For example "v1/Pod" -> typeof(V1Pod). If null, a default mapping will
    /// be used.
    /// </param>
    /// <returns>collection of objects</returns>
    public static List<object> LoadAllFromString(string content, IDictionary<string, Type> typeMap = null)
    {
        var mergedTypeMap = new Dictionary<string, Type>(ModelTypeMap);
        // merge in KVPs from typeMap, overriding any in ModelTypeMap
        typeMap?.ToList().ForEach(x => mergedTypeMap[x.Key] = x.Value);

        var types = new List<Type>();
        var parser = new Parser(new StringReader(content));
        parser.Consume<StreamStart>();
        while (parser.Accept<DocumentStart>(out _))
        {
            var obj = Deserializer.Deserialize<KubernetesObject>(parser);
            types.Add(mergedTypeMap[obj.ApiVersion + "/" + obj.Kind]);
        }

        parser = new Parser(new StringReader(content));
        parser.Consume<StreamStart>();
        var ix = 0;
        var results = new List<object>();
        while (parser.Accept<DocumentStart>(out _))
        {
            var objType = types[ix++];
            var obj = Deserializer.Deserialize(parser, objType);
            results.Add(obj);
        }

        return results;
    }

    public static async Task<T> LoadFromStreamAsync<T>(Stream stream)
    {
        var reader = new StreamReader(stream);
        var content = await reader.ReadToEndAsync().ConfigureAwait(false);
        return Deserialize<T>(content);
    }

    public static async Task<T> LoadFromFileAsync<T>(string file)
    {
        using (var fs = File.OpenRead(file))
        {
            return await LoadFromStreamAsync<T>(fs).ConfigureAwait(false);
        }
    }

    public static TValue Deserialize<TValue>(string yaml)
    {
        return Deserializer.Deserialize<TValue>(yaml);
    }

    public static TValue Deserialize<TValue>(Stream yaml)
    {
        return Deserializer.Deserialize<TValue>(new StreamReader(yaml));
    }

    public static string SerializeAll(IEnumerable<object> values)
    {
        if (values == null)
        {
            return "";
        }

        var stringBuilder = new StringBuilder();
        var writer = new StringWriter(stringBuilder);
        var emitter = new Emitter(writer);

        emitter.Emit(new StreamStart());

        foreach (var value in values)
        {
            if (value != null)
            {
                emitter.Emit(new DocumentStart());
                Serializer.SerializeValue(emitter, value, value.GetType());
                emitter.Emit(new DocumentEnd(true));
            }
        }

        return stringBuilder.ToString();
    }

    public static string Serialize(object value)
    {
        if (value == null)
        {
            return "";
        }

        var stringBuilder = new StringBuilder();
        var writer = new StringWriter(stringBuilder);
        var emitter = new Emitter(writer);

        emitter.Emit(new StreamStart());
        emitter.Emit(new DocumentStart());
        Serializer.SerializeValue(emitter, value, value.GetType());

        return stringBuilder.ToString();
    }
}
