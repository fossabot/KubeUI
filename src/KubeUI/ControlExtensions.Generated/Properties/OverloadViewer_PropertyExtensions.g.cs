#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using AvaloniaEdit.CodeCompletion;
using OverloadViewer = AvaloniaEdit.CodeCompletion.OverloadViewer;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class OverloadViewerExtensions
{
public static T Text<T>(this T control, IBinding binding) where T : AvaloniaEdit.CodeCompletion.OverloadViewer
   => control._set(AvaloniaEdit.CodeCompletion.OverloadViewer.TextProperty, binding);
public static T Text<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : AvaloniaEdit.CodeCompletion.OverloadViewer
   => control._set(AvaloniaEdit.CodeCompletion.OverloadViewer.TextProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Text<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : AvaloniaEdit.CodeCompletion.OverloadViewer
   => control._set(AvaloniaEdit.CodeCompletion.OverloadViewer.TextProperty, func, onChanged, expression);
public static T Text<T>(this T control, System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : AvaloniaEdit.CodeCompletion.OverloadViewer
=> control._setEx(AvaloniaEdit.CodeCompletion.OverloadViewer.TextProperty, ps, () => control.Text = value, bindingMode, converter, bindingSource);
public static T Text<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : AvaloniaEdit.CodeCompletion.OverloadViewer
=> control._setEx(AvaloniaEdit.CodeCompletion.OverloadViewer.TextProperty, ps, () => control.Text = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Provider<T>(this T control, IBinding binding) where T : AvaloniaEdit.CodeCompletion.OverloadViewer
   => control._set(AvaloniaEdit.CodeCompletion.OverloadViewer.ProviderProperty, binding);
public static T Provider<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : AvaloniaEdit.CodeCompletion.OverloadViewer
   => control._set(AvaloniaEdit.CodeCompletion.OverloadViewer.ProviderProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Provider<T>(this T control, Func<AvaloniaEdit.CodeCompletion.IOverloadProvider> func, Action<AvaloniaEdit.CodeCompletion.IOverloadProvider>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : AvaloniaEdit.CodeCompletion.OverloadViewer
   => control._set(AvaloniaEdit.CodeCompletion.OverloadViewer.ProviderProperty, func, onChanged, expression);
public static T Provider<T>(this T control, AvaloniaEdit.CodeCompletion.IOverloadProvider value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : AvaloniaEdit.CodeCompletion.OverloadViewer
=> control._setEx(AvaloniaEdit.CodeCompletion.OverloadViewer.ProviderProperty, ps, () => control.Provider = value, bindingMode, converter, bindingSource);
public static T Provider<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, AvaloniaEdit.CodeCompletion.IOverloadProvider> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : AvaloniaEdit.CodeCompletion.OverloadViewer
=> control._setEx(AvaloniaEdit.CodeCompletion.OverloadViewer.ProviderProperty, ps, () => control.Provider = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
