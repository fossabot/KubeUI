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
public static partial class ClockTicks_MarkupExtensions
{
//================= Properties ======================//
 // ShowHourTicksProperty

/*BindFromExpressionSetterGenerator*/
public static T ShowHourTicks<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Ursa.Controls.ClockTicks
   => control._set(Ursa.Controls.ClockTicks.ShowHourTicksProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T ShowHourTicks<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Ursa.Controls.ClockTicks
=> control._setEx(Ursa.Controls.ClockTicks.ShowHourTicksProperty, ps, () => control.ShowHourTicks = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ShowHourTicks<T>(this T control, IBinding binding) where T : Ursa.Controls.ClockTicks
   => control._set(Ursa.Controls.ClockTicks.ShowHourTicksProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ShowHourTicks<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.ClockTicks
   => control._set(Ursa.Controls.ClockTicks.ShowHourTicksProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T ShowHourTicks<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Ursa.Controls.ClockTicks
=> control._setEx(Ursa.Controls.ClockTicks.ShowHourTicksProperty, ps, () => control.ShowHourTicks = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // ShowMinuteTicksProperty

/*BindFromExpressionSetterGenerator*/
public static T ShowMinuteTicks<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Ursa.Controls.ClockTicks
   => control._set(Ursa.Controls.ClockTicks.ShowMinuteTicksProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T ShowMinuteTicks<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Ursa.Controls.ClockTicks
=> control._setEx(Ursa.Controls.ClockTicks.ShowMinuteTicksProperty, ps, () => control.ShowMinuteTicks = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ShowMinuteTicks<T>(this T control, IBinding binding) where T : Ursa.Controls.ClockTicks
   => control._set(Ursa.Controls.ClockTicks.ShowMinuteTicksProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ShowMinuteTicks<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.ClockTicks
   => control._set(Ursa.Controls.ClockTicks.ShowMinuteTicksProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T ShowMinuteTicks<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Ursa.Controls.ClockTicks
=> control._setEx(Ursa.Controls.ClockTicks.ShowMinuteTicksProperty, ps, () => control.ShowMinuteTicks = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // HourTickForegroundProperty

/*BindFromExpressionSetterGenerator*/
public static T HourTickForeground<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Ursa.Controls.ClockTicks
   => control._set(Ursa.Controls.ClockTicks.HourTickForegroundProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T HourTickForeground<T>(this T control, Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Ursa.Controls.ClockTicks
=> control._setEx(Ursa.Controls.ClockTicks.HourTickForegroundProperty, ps, () => control.HourTickForeground = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T HourTickForeground<T>(this T control, IBinding binding) where T : Ursa.Controls.ClockTicks
   => control._set(Ursa.Controls.ClockTicks.HourTickForegroundProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HourTickForeground<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.ClockTicks
   => control._set(Ursa.Controls.ClockTicks.HourTickForegroundProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T HourTickForeground<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Ursa.Controls.ClockTicks
=> control._setEx(Ursa.Controls.ClockTicks.HourTickForegroundProperty, ps, () => control.HourTickForeground = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // MinuteTickForegroundProperty

/*BindFromExpressionSetterGenerator*/
public static T MinuteTickForeground<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Ursa.Controls.ClockTicks
   => control._set(Ursa.Controls.ClockTicks.MinuteTickForegroundProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T MinuteTickForeground<T>(this T control, Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Ursa.Controls.ClockTicks
=> control._setEx(Ursa.Controls.ClockTicks.MinuteTickForegroundProperty, ps, () => control.MinuteTickForeground = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MinuteTickForeground<T>(this T control, IBinding binding) where T : Ursa.Controls.ClockTicks
   => control._set(Ursa.Controls.ClockTicks.MinuteTickForegroundProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MinuteTickForeground<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.ClockTicks
   => control._set(Ursa.Controls.ClockTicks.MinuteTickForegroundProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T MinuteTickForeground<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Ursa.Controls.ClockTicks
=> control._setEx(Ursa.Controls.ClockTicks.MinuteTickForegroundProperty, ps, () => control.MinuteTickForeground = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // HourTickLengthProperty

/*BindFromExpressionSetterGenerator*/
public static T HourTickLength<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Ursa.Controls.ClockTicks
   => control._set(Ursa.Controls.ClockTicks.HourTickLengthProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T HourTickLength<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Ursa.Controls.ClockTicks
=> control._setEx(Ursa.Controls.ClockTicks.HourTickLengthProperty, ps, () => control.HourTickLength = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T HourTickLength<T>(this T control, IBinding binding) where T : Ursa.Controls.ClockTicks
   => control._set(Ursa.Controls.ClockTicks.HourTickLengthProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HourTickLength<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.ClockTicks
   => control._set(Ursa.Controls.ClockTicks.HourTickLengthProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T HourTickLength<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Ursa.Controls.ClockTicks
=> control._setEx(Ursa.Controls.ClockTicks.HourTickLengthProperty, ps, () => control.HourTickLength = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // MinuteTickLengthProperty

/*BindFromExpressionSetterGenerator*/
public static T MinuteTickLength<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Ursa.Controls.ClockTicks
   => control._set(Ursa.Controls.ClockTicks.MinuteTickLengthProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T MinuteTickLength<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Ursa.Controls.ClockTicks
=> control._setEx(Ursa.Controls.ClockTicks.MinuteTickLengthProperty, ps, () => control.MinuteTickLength = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MinuteTickLength<T>(this T control, IBinding binding) where T : Ursa.Controls.ClockTicks
   => control._set(Ursa.Controls.ClockTicks.MinuteTickLengthProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MinuteTickLength<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.ClockTicks
   => control._set(Ursa.Controls.ClockTicks.MinuteTickLengthProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T MinuteTickLength<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Ursa.Controls.ClockTicks
=> control._setEx(Ursa.Controls.ClockTicks.MinuteTickLengthProperty, ps, () => control.MinuteTickLength = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // HourTickWidthProperty

/*BindFromExpressionSetterGenerator*/
public static T HourTickWidth<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Ursa.Controls.ClockTicks
   => control._set(Ursa.Controls.ClockTicks.HourTickWidthProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T HourTickWidth<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Ursa.Controls.ClockTicks
=> control._setEx(Ursa.Controls.ClockTicks.HourTickWidthProperty, ps, () => control.HourTickWidth = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T HourTickWidth<T>(this T control, IBinding binding) where T : Ursa.Controls.ClockTicks
   => control._set(Ursa.Controls.ClockTicks.HourTickWidthProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HourTickWidth<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.ClockTicks
   => control._set(Ursa.Controls.ClockTicks.HourTickWidthProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T HourTickWidth<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Ursa.Controls.ClockTicks
=> control._setEx(Ursa.Controls.ClockTicks.HourTickWidthProperty, ps, () => control.HourTickWidth = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // MinuteTickWidthProperty

/*BindFromExpressionSetterGenerator*/
public static T MinuteTickWidth<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Ursa.Controls.ClockTicks
   => control._set(Ursa.Controls.ClockTicks.MinuteTickWidthProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T MinuteTickWidth<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Ursa.Controls.ClockTicks
=> control._setEx(Ursa.Controls.ClockTicks.MinuteTickWidthProperty, ps, () => control.MinuteTickWidth = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MinuteTickWidth<T>(this T control, IBinding binding) where T : Ursa.Controls.ClockTicks
   => control._set(Ursa.Controls.ClockTicks.MinuteTickWidthProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MinuteTickWidth<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.ClockTicks
   => control._set(Ursa.Controls.ClockTicks.MinuteTickWidthProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T MinuteTickWidth<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Ursa.Controls.ClockTicks
=> control._setEx(Ursa.Controls.ClockTicks.MinuteTickWidthProperty, ps, () => control.MinuteTickWidth = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Events ======================//

//================= Styles ======================//
 // ShowHourTicksProperty

/*ValueStyleSetterGenerator*/
public static Style<T> ShowHourTicks<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.ClockTicks
=> style._addSetter(Ursa.Controls.ClockTicks.ShowHourTicksProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> ShowHourTicks<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.ClockTicks
=> style._addSetter(Ursa.Controls.ClockTicks.ShowHourTicksProperty, binding);


 // ShowMinuteTicksProperty

/*ValueStyleSetterGenerator*/
public static Style<T> ShowMinuteTicks<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.ClockTicks
=> style._addSetter(Ursa.Controls.ClockTicks.ShowMinuteTicksProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> ShowMinuteTicks<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.ClockTicks
=> style._addSetter(Ursa.Controls.ClockTicks.ShowMinuteTicksProperty, binding);


 // HourTickForegroundProperty

/*ValueStyleSetterGenerator*/
public static Style<T> HourTickForeground<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Ursa.Controls.ClockTicks
=> style._addSetter(Ursa.Controls.ClockTicks.HourTickForegroundProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> HourTickForeground<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.ClockTicks
=> style._addSetter(Ursa.Controls.ClockTicks.HourTickForegroundProperty, binding);


 // MinuteTickForegroundProperty

/*ValueStyleSetterGenerator*/
public static Style<T> MinuteTickForeground<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Ursa.Controls.ClockTicks
=> style._addSetter(Ursa.Controls.ClockTicks.MinuteTickForegroundProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> MinuteTickForeground<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.ClockTicks
=> style._addSetter(Ursa.Controls.ClockTicks.MinuteTickForegroundProperty, binding);


 // HourTickLengthProperty

/*ValueStyleSetterGenerator*/
public static Style<T> HourTickLength<T>(this Style<T> style, System.Double value) where T : Ursa.Controls.ClockTicks
=> style._addSetter(Ursa.Controls.ClockTicks.HourTickLengthProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> HourTickLength<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.ClockTicks
=> style._addSetter(Ursa.Controls.ClockTicks.HourTickLengthProperty, binding);


 // MinuteTickLengthProperty

/*ValueStyleSetterGenerator*/
public static Style<T> MinuteTickLength<T>(this Style<T> style, System.Double value) where T : Ursa.Controls.ClockTicks
=> style._addSetter(Ursa.Controls.ClockTicks.MinuteTickLengthProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> MinuteTickLength<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.ClockTicks
=> style._addSetter(Ursa.Controls.ClockTicks.MinuteTickLengthProperty, binding);


 // HourTickWidthProperty

/*ValueStyleSetterGenerator*/
public static Style<T> HourTickWidth<T>(this Style<T> style, System.Double value) where T : Ursa.Controls.ClockTicks
=> style._addSetter(Ursa.Controls.ClockTicks.HourTickWidthProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> HourTickWidth<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.ClockTicks
=> style._addSetter(Ursa.Controls.ClockTicks.HourTickWidthProperty, binding);


 // MinuteTickWidthProperty

/*ValueStyleSetterGenerator*/
public static Style<T> MinuteTickWidth<T>(this Style<T> style, System.Double value) where T : Ursa.Controls.ClockTicks
=> style._addSetter(Ursa.Controls.ClockTicks.MinuteTickWidthProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> MinuteTickWidth<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.ClockTicks
=> style._addSetter(Ursa.Controls.ClockTicks.MinuteTickWidthProperty, binding);



}