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
public static partial class EnumSelector_MarkupExtensions
{
//================= Properties ======================//
 // EnumTypeProperty

/*BindFromExpressionSetterGenerator*/
public static T EnumType<T>(this T control, Func<System.Type> func, Action<System.Type>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Ursa.Controls.EnumSelector
   => control._set(Ursa.Controls.EnumSelector.EnumTypeProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T EnumType<T>(this T control, System.Type value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Ursa.Controls.EnumSelector
=> control._setEx(Ursa.Controls.EnumSelector.EnumTypeProperty, ps, () => control.EnumType = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T EnumType<T>(this T control, IBinding binding) where T : Ursa.Controls.EnumSelector
   => control._set(Ursa.Controls.EnumSelector.EnumTypeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T EnumType<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.EnumSelector
   => control._set(Ursa.Controls.EnumSelector.EnumTypeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T EnumType<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Type> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Ursa.Controls.EnumSelector
=> control._setEx(Ursa.Controls.EnumSelector.EnumTypeProperty, ps, () => control.EnumType = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // ValueProperty

/*BindFromExpressionSetterGenerator*/
public static T Value<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Ursa.Controls.EnumSelector
   => control._set(Ursa.Controls.EnumSelector.ValueProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Value<T>(this T control, System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Ursa.Controls.EnumSelector
=> control._setEx(Ursa.Controls.EnumSelector.ValueProperty, ps, () => control.Value = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Value<T>(this T control, IBinding binding) where T : Ursa.Controls.EnumSelector
   => control._set(Ursa.Controls.EnumSelector.ValueProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Value<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.EnumSelector
   => control._set(Ursa.Controls.EnumSelector.ValueProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Value<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Ursa.Controls.EnumSelector
=> control._setEx(Ursa.Controls.EnumSelector.ValueProperty, ps, () => control.Value = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // DisplayDescriptionProperty

/*BindFromExpressionSetterGenerator*/
public static T DisplayDescription<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Ursa.Controls.EnumSelector
   => control._set(Ursa.Controls.EnumSelector.DisplayDescriptionProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T DisplayDescription<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Ursa.Controls.EnumSelector
=> control._setEx(Ursa.Controls.EnumSelector.DisplayDescriptionProperty, ps, () => control.DisplayDescription = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T DisplayDescription<T>(this T control, IBinding binding) where T : Ursa.Controls.EnumSelector
   => control._set(Ursa.Controls.EnumSelector.DisplayDescriptionProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DisplayDescription<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.EnumSelector
   => control._set(Ursa.Controls.EnumSelector.DisplayDescriptionProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T DisplayDescription<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Ursa.Controls.EnumSelector
=> control._setEx(Ursa.Controls.EnumSelector.DisplayDescriptionProperty, ps, () => control.DisplayDescription = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Events ======================//

//================= Styles ======================//
 // EnumTypeProperty

/*ValueStyleSetterGenerator*/
public static Style<T> EnumType<T>(this Style<T> style, System.Type value) where T : Ursa.Controls.EnumSelector
=> style._addSetter(Ursa.Controls.EnumSelector.EnumTypeProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> EnumType<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.EnumSelector
=> style._addSetter(Ursa.Controls.EnumSelector.EnumTypeProperty, binding);


 // ValueProperty

/*ValueStyleSetterGenerator*/
public static Style<T> Value<T>(this Style<T> style, System.Object value) where T : Ursa.Controls.EnumSelector
=> style._addSetter(Ursa.Controls.EnumSelector.ValueProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Value<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.EnumSelector
=> style._addSetter(Ursa.Controls.EnumSelector.ValueProperty, binding);


 // DisplayDescriptionProperty

/*ValueStyleSetterGenerator*/
public static Style<T> DisplayDescription<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.EnumSelector
=> style._addSetter(Ursa.Controls.EnumSelector.DisplayDescriptionProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> DisplayDescription<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.EnumSelector
=> style._addSetter(Ursa.Controls.EnumSelector.DisplayDescriptionProperty, binding);



}
