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
public static partial class IconButton_MarkupExtensions
{
//================= Properties ======================//
 // IconProperty

/*BindFromExpressionSetterGenerator*/
public static T Icon<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Ursa.Controls.IconButton
   => control._set(Ursa.Controls.IconButton.IconProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Icon<T>(this T control, System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Ursa.Controls.IconButton
=> control._setEx(Ursa.Controls.IconButton.IconProperty, ps, () => control.Icon = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Icon<T>(this T control, IBinding binding) where T : Ursa.Controls.IconButton
   => control._set(Ursa.Controls.IconButton.IconProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Icon<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.IconButton
   => control._set(Ursa.Controls.IconButton.IconProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Icon<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Ursa.Controls.IconButton
=> control._setEx(Ursa.Controls.IconButton.IconProperty, ps, () => control.Icon = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // IconTemplateProperty

/*BindFromExpressionSetterGenerator*/
public static T IconTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate> func, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Ursa.Controls.IconButton
   => control._set(Ursa.Controls.IconButton.IconTemplateProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T IconTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Ursa.Controls.IconButton
=> control._setEx(Ursa.Controls.IconButton.IconTemplateProperty, ps, () => control.IconTemplate = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IconTemplate<T>(this T control, IBinding binding) where T : Ursa.Controls.IconButton
   => control._set(Ursa.Controls.IconButton.IconTemplateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IconTemplate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.IconButton
   => control._set(Ursa.Controls.IconButton.IconTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T IconTemplate<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Templates.IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Ursa.Controls.IconButton
=> control._setEx(Ursa.Controls.IconButton.IconTemplateProperty, ps, () => control.IconTemplate = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // IsLoadingProperty

/*BindFromExpressionSetterGenerator*/
public static T IsLoading<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Ursa.Controls.IconButton
   => control._set(Ursa.Controls.IconButton.IsLoadingProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T IsLoading<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Ursa.Controls.IconButton
=> control._setEx(Ursa.Controls.IconButton.IsLoadingProperty, ps, () => control.IsLoading = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsLoading<T>(this T control, IBinding binding) where T : Ursa.Controls.IconButton
   => control._set(Ursa.Controls.IconButton.IsLoadingProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsLoading<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.IconButton
   => control._set(Ursa.Controls.IconButton.IsLoadingProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T IsLoading<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Ursa.Controls.IconButton
=> control._setEx(Ursa.Controls.IconButton.IsLoadingProperty, ps, () => control.IsLoading = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // IconPlacementProperty

/*BindFromExpressionSetterGenerator*/
public static T IconPlacement<T>(this T control, Func<Ursa.Common.Position> func, Action<Ursa.Common.Position>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Ursa.Controls.IconButton
   => control._set(Ursa.Controls.IconButton.IconPlacementProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T IconPlacement<T>(this T control, Ursa.Common.Position value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Ursa.Controls.IconButton
=> control._setEx(Ursa.Controls.IconButton.IconPlacementProperty, ps, () => control.IconPlacement = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IconPlacement<T>(this T control, IBinding binding) where T : Ursa.Controls.IconButton
   => control._set(Ursa.Controls.IconButton.IconPlacementProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IconPlacement<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.IconButton
   => control._set(Ursa.Controls.IconButton.IconPlacementProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T IconPlacement<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Ursa.Common.Position> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Ursa.Controls.IconButton
=> control._setEx(Ursa.Controls.IconButton.IconPlacementProperty, ps, () => control.IconPlacement = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Events ======================//

//================= Styles ======================//
 // IconProperty

/*ValueStyleSetterGenerator*/
public static Style<T> Icon<T>(this Style<T> style, System.Object value) where T : Ursa.Controls.IconButton
=> style._addSetter(Ursa.Controls.IconButton.IconProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Icon<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.IconButton
=> style._addSetter(Ursa.Controls.IconButton.IconProperty, binding);


 // IconTemplateProperty

/*ValueStyleSetterGenerator*/
public static Style<T> IconTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate value) where T : Ursa.Controls.IconButton
=> style._addSetter(Ursa.Controls.IconButton.IconTemplateProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> IconTemplate<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.IconButton
=> style._addSetter(Ursa.Controls.IconButton.IconTemplateProperty, binding);


 // IsLoadingProperty

/*ValueStyleSetterGenerator*/
public static Style<T> IsLoading<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.IconButton
=> style._addSetter(Ursa.Controls.IconButton.IsLoadingProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> IsLoading<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.IconButton
=> style._addSetter(Ursa.Controls.IconButton.IsLoadingProperty, binding);


 // IconPlacementProperty

/*ValueStyleSetterGenerator*/
public static Style<T> IconPlacement<T>(this Style<T> style, Ursa.Common.Position value) where T : Ursa.Controls.IconButton
=> style._addSetter(Ursa.Controls.IconButton.IconPlacementProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> IconPlacement<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.IconButton
=> style._addSetter(Ursa.Controls.IconButton.IconPlacementProperty, binding);



}
