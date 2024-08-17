#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using Avalonia.Themes.Fluent;
using ColorPaletteResources = Avalonia.Themes.Fluent.ColorPaletteResources;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ColorPaletteResourcesExtensions
{
public static T Accent<T>(this T control, IBinding binding) where T : Avalonia.Themes.Fluent.ColorPaletteResources
   => control._set(Avalonia.Themes.Fluent.ColorPaletteResources.AccentProperty, binding);
public static T Accent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Themes.Fluent.ColorPaletteResources
   => control._set(Avalonia.Themes.Fluent.ColorPaletteResources.AccentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Accent<T>(this T control, Func<Avalonia.Media.Color> func, Action<Avalonia.Media.Color>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Themes.Fluent.ColorPaletteResources
   => control._set(Avalonia.Themes.Fluent.ColorPaletteResources.AccentProperty, func, onChanged, expression);
public static T Accent<T>(this T control, Avalonia.Media.Color value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Themes.Fluent.ColorPaletteResources
=> control._setEx(Avalonia.Themes.Fluent.ColorPaletteResources.AccentProperty, ps, () => control.Accent = value, bindingMode, converter, bindingSource);
public static T Accent<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.Color> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Themes.Fluent.ColorPaletteResources
=> control._setEx(Avalonia.Themes.Fluent.ColorPaletteResources.AccentProperty, ps, () => control.Accent = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
