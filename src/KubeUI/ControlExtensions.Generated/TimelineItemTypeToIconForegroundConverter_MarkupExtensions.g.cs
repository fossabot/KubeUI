#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "11.1.3.0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class TimelineItemTypeToIconForegroundConverter_MarkupExtensions
{
//================= Properties ======================//
 // DefaultBrushProperty

/*BindFromExpressionSetterGenerator*/
public static T DefaultBrush<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter
   => control._set(Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter.DefaultBrushProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T DefaultBrush<T>(this T control, Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter
=> control._setEx(Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter.DefaultBrushProperty, ps, () => control.DefaultBrush = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T DefaultBrush<T>(this T control, IBinding binding) where T : Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter
   => control._set(Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter.DefaultBrushProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DefaultBrush<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter
   => control._set(Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter.DefaultBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T DefaultBrush<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter
=> control._setEx(Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter.DefaultBrushProperty, ps, () => control.DefaultBrush = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // OngoingBrushProperty

/*BindFromExpressionSetterGenerator*/
public static T OngoingBrush<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter
   => control._set(Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter.OngoingBrushProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T OngoingBrush<T>(this T control, Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter
=> control._setEx(Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter.OngoingBrushProperty, ps, () => control.OngoingBrush = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T OngoingBrush<T>(this T control, IBinding binding) where T : Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter
   => control._set(Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter.OngoingBrushProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T OngoingBrush<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter
   => control._set(Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter.OngoingBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T OngoingBrush<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter
=> control._setEx(Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter.OngoingBrushProperty, ps, () => control.OngoingBrush = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // SuccessBrushProperty

/*BindFromExpressionSetterGenerator*/
public static T SuccessBrush<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter
   => control._set(Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter.SuccessBrushProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T SuccessBrush<T>(this T control, Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter
=> control._setEx(Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter.SuccessBrushProperty, ps, () => control.SuccessBrush = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SuccessBrush<T>(this T control, IBinding binding) where T : Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter
   => control._set(Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter.SuccessBrushProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SuccessBrush<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter
   => control._set(Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter.SuccessBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T SuccessBrush<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter
=> control._setEx(Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter.SuccessBrushProperty, ps, () => control.SuccessBrush = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // WarningBrushProperty

/*BindFromExpressionSetterGenerator*/
public static T WarningBrush<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter
   => control._set(Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter.WarningBrushProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T WarningBrush<T>(this T control, Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter
=> control._setEx(Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter.WarningBrushProperty, ps, () => control.WarningBrush = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T WarningBrush<T>(this T control, IBinding binding) where T : Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter
   => control._set(Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter.WarningBrushProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T WarningBrush<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter
   => control._set(Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter.WarningBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T WarningBrush<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter
=> control._setEx(Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter.WarningBrushProperty, ps, () => control.WarningBrush = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // ErrorBrushProperty

/*BindFromExpressionSetterGenerator*/
public static T ErrorBrush<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter
   => control._set(Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter.ErrorBrushProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T ErrorBrush<T>(this T control, Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter
=> control._setEx(Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter.ErrorBrushProperty, ps, () => control.ErrorBrush = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ErrorBrush<T>(this T control, IBinding binding) where T : Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter
   => control._set(Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter.ErrorBrushProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ErrorBrush<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter
   => control._set(Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter.ErrorBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T ErrorBrush<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter
=> control._setEx(Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter.ErrorBrushProperty, ps, () => control.ErrorBrush = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Events ======================//

//================= Styles ======================//

}
