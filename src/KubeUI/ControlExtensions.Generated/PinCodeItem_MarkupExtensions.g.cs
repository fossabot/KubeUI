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
public static partial class PinCodeItem_MarkupExtensions
{
//================= Properties ======================//
 // TextProperty

/*BindFromExpressionSetterGenerator*/
public static T Text<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Ursa.Controls.PinCodeItem
   => control._set(Ursa.Controls.PinCodeItem.TextProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Text<T>(this T control, System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Ursa.Controls.PinCodeItem
=> control._setEx(Ursa.Controls.PinCodeItem.TextProperty, ps, () => control.Text = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Text<T>(this T control, IBinding binding) where T : Ursa.Controls.PinCodeItem
   => control._set(Ursa.Controls.PinCodeItem.TextProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Text<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.PinCodeItem
   => control._set(Ursa.Controls.PinCodeItem.TextProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Text<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Ursa.Controls.PinCodeItem
=> control._setEx(Ursa.Controls.PinCodeItem.TextProperty, ps, () => control.Text = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // PasswordCharProperty

/*BindFromExpressionSetterGenerator*/
public static T PasswordChar<T>(this T control, Func<System.Char> func, Action<System.Char>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Ursa.Controls.PinCodeItem
   => control._set(Ursa.Controls.PinCodeItem.PasswordCharProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T PasswordChar<T>(this T control, System.Char value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Ursa.Controls.PinCodeItem
=> control._setEx(Ursa.Controls.PinCodeItem.PasswordCharProperty, ps, () => control.PasswordChar = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PasswordChar<T>(this T control, IBinding binding) where T : Ursa.Controls.PinCodeItem
   => control._set(Ursa.Controls.PinCodeItem.PasswordCharProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PasswordChar<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.PinCodeItem
   => control._set(Ursa.Controls.PinCodeItem.PasswordCharProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T PasswordChar<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Char> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Ursa.Controls.PinCodeItem
=> control._setEx(Ursa.Controls.PinCodeItem.PasswordCharProperty, ps, () => control.PasswordChar = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Events ======================//

//================= Styles ======================//
 // TextProperty

/*ValueStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, System.String value) where T : Ursa.Controls.PinCodeItem
=> style._addSetter(Ursa.Controls.PinCodeItem.TextProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.PinCodeItem
=> style._addSetter(Ursa.Controls.PinCodeItem.TextProperty, binding);


 // PasswordCharProperty

/*ValueStyleSetterGenerator*/
public static Style<T> PasswordChar<T>(this Style<T> style, System.Char value) where T : Ursa.Controls.PinCodeItem
=> style._addSetter(Ursa.Controls.PinCodeItem.PasswordCharProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> PasswordChar<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.PinCodeItem
=> style._addSetter(Ursa.Controls.PinCodeItem.PasswordCharProperty, binding);



}
