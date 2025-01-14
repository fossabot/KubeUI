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
public static partial class TaskDialogButtonHost_MarkupExtensions
{
//================= Properties ======================//
 // IconSourceProperty

/*BindFromExpressionSetterGenerator*/
public static T IconSource<T>(this T control, Func<FluentAvalonia.UI.Controls.IconSource> func, Action<FluentAvalonia.UI.Controls.IconSource>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : FluentAvalonia.UI.Controls.Primitives.TaskDialogButtonHost
   => control._set(FluentAvalonia.UI.Controls.Primitives.TaskDialogButtonHost.IconSourceProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T IconSource<T>(this T control, FluentAvalonia.UI.Controls.IconSource value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : FluentAvalonia.UI.Controls.Primitives.TaskDialogButtonHost
=> control._setEx(FluentAvalonia.UI.Controls.Primitives.TaskDialogButtonHost.IconSourceProperty, ps, () => control.IconSource = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IconSource<T>(this T control, IBinding binding) where T : FluentAvalonia.UI.Controls.Primitives.TaskDialogButtonHost
   => control._set(FluentAvalonia.UI.Controls.Primitives.TaskDialogButtonHost.IconSourceProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IconSource<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : FluentAvalonia.UI.Controls.Primitives.TaskDialogButtonHost
   => control._set(FluentAvalonia.UI.Controls.Primitives.TaskDialogButtonHost.IconSourceProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T IconSource<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, FluentAvalonia.UI.Controls.IconSource> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : FluentAvalonia.UI.Controls.Primitives.TaskDialogButtonHost
=> control._setEx(FluentAvalonia.UI.Controls.Primitives.TaskDialogButtonHost.IconSourceProperty, ps, () => control.IconSource = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Events ======================//

//================= Styles ======================//
 // IconSourceProperty

/*ValueStyleSetterGenerator*/
public static Style<T> IconSource<T>(this Style<T> style, FluentAvalonia.UI.Controls.IconSource value) where T : FluentAvalonia.UI.Controls.Primitives.TaskDialogButtonHost
=> style._addSetter(FluentAvalonia.UI.Controls.Primitives.TaskDialogButtonHost.IconSourceProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> IconSource<T>(this Style<T> style, IBinding binding) where T : FluentAvalonia.UI.Controls.Primitives.TaskDialogButtonHost
=> style._addSetter(FluentAvalonia.UI.Controls.Primitives.TaskDialogButtonHost.IconSourceProperty, binding);



}
