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
public static partial class WindowMessageManager_MarkupExtensions
{
//================= Properties ======================//
 // MaxItemsProperty

/*BindFromExpressionSetterGenerator*/
public static T MaxItems<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Ursa.Controls.WindowMessageManager
   => control._set(Ursa.Controls.WindowMessageManager.MaxItemsProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T MaxItems<T>(this T control, System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Ursa.Controls.WindowMessageManager
=> control._setEx(Ursa.Controls.WindowMessageManager.MaxItemsProperty, ps, () => control.MaxItems = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MaxItems<T>(this T control, IBinding binding) where T : Ursa.Controls.WindowMessageManager
   => control._set(Ursa.Controls.WindowMessageManager.MaxItemsProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MaxItems<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.WindowMessageManager
   => control._set(Ursa.Controls.WindowMessageManager.MaxItemsProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T MaxItems<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Ursa.Controls.WindowMessageManager
=> control._setEx(Ursa.Controls.WindowMessageManager.MaxItemsProperty, ps, () => control.MaxItems = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Events ======================//

//================= Styles ======================//
 // MaxItemsProperty

/*ValueStyleSetterGenerator*/
public static Style<T> MaxItems<T>(this Style<T> style, System.Int32 value) where T : Ursa.Controls.WindowMessageManager
=> style._addSetter(Ursa.Controls.WindowMessageManager.MaxItemsProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxItems<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.WindowMessageManager
=> style._addSetter(Ursa.Controls.WindowMessageManager.MaxItemsProperty, binding);



}