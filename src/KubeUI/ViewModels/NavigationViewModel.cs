﻿using Avalonia.Platform.Storage;
using Dock.Model.Core;
using k8s;
using k8s.Models;
using KubeUI.Assets;
using KubeUI.Client;
using Microsoft.Extensions.DependencyInjection;

namespace KubeUI.ViewModels;

public sealed partial class NavigationViewModel : ViewModelBase
{
    [ObservableProperty]
    private ClusterManager _clusterManager;

    public NavigationViewModel()
    {
        ClusterManager = Application.Current.GetRequiredService<ClusterManager>();
        Factory = Application.Current.GetRequiredService<IFactory>();
    }

    [ActivatorUtilitiesConstructor]
    public NavigationViewModel(ClusterManager clusterManager, IFactory factory)
    {
        ClusterManager = clusterManager;
        Factory = factory;
    }

    public async void TreeView_SelectionChanged(object? item)
    {
        if (item is Cluster cluster)
        {
            _ = Task.Run(cluster.Connect);
        }
        else if (item is ResourceNavigationLink resourceNavLink)
        {
            var kind = GroupApiVersionKind.From(resourceNavLink.ControlType);

            resourceNavLink.Cluster.Seed(resourceNavLink.ControlType);
            resourceNavLink.Objects = resourceNavLink.Cluster.Objects[kind].Items;

            var vm = GetContext(resourceNavLink.ControlType, resourceNavLink.Objects, kind, resourceNavLink.Cluster) as IDockable;
            vm.Title = kind.ToString();
            vm.Id = resourceNavLink.Cluster.Name + "-" + kind.ToString();

            Factory.AddToDocuments(vm);
        }
        else if (item is NavigationLink navLink)
        {
            if (navLink.Id == "load-yaml")
            {
                // Start async operation to open the dialog.
                var files = await App.TopLevel.StorageProvider.OpenFilePickerAsync(new FilePickerOpenOptions
                {
                    Title = Resources.NavigationViewModel_LoadYaml,
                    AllowMultiple = true,
                    FileTypeFilter = new List<FilePickerFileType>() { new("Yaml") { Patterns = ["*.yaml", ".yml"] } }
                });

                foreach (var file in files)
                {
                    var stream = await file.OpenReadAsync();
                    navLink.Cluster.ImportYaml(stream);
                }
            }
            else if (navLink.Id == "load-folder")
            {
                // Start async operation to open the dialog.
                var folders = await App.TopLevel.StorageProvider.OpenFolderPickerAsync(new FolderPickerOpenOptions
                {
                    Title = Resources.NavigationViewModel_LoadFolder,
                    AllowMultiple = false
                });

                foreach (var file in folders)
                {
                    navLink.Cluster.ImportFolder(file.TryGetLocalPath());
                }
            }
            else
            {
                var vm = Application.Current.GetRequiredService(navLink.ControlType) as IDockable;

                vm.Title = navLink.Name;
                vm.Id = navLink.Cluster.Name + "-" + navLink.Name;

                navLink.ControlType.GetProperty(nameof(ResourceListViewModel<V1Pod>.Cluster))?.SetValue(vm, navLink.Cluster);

                Factory.AddToDocuments(vm);
            }
        }
    }

    private static object GetContext(Type type, object list, GroupApiVersionKind kind, Cluster cluster)
    {
        var constructedType = typeof(ResourceListViewModel<>).MakeGenericType(type);

        var instance = Application.Current.GetRequiredService(constructedType);

        constructedType.GetProperty(nameof(ResourceListViewModel<V1Pod>.Cluster))?.SetValue(instance, cluster);
        constructedType.GetProperty(nameof(ResourceListViewModel<V1Pod>.Objects))?.SetValue(instance, list);
        constructedType.GetProperty(nameof(ResourceListViewModel<V1Pod>.Kind))?.SetValue(instance, kind);

        constructedType.GetMethod(nameof(ResourceListViewModel<V1Pod>.Initialize))?.Invoke(instance, null);

        return instance;
    }
}

public partial class NavigationItem : ObservableObject
{
    [ObservableProperty]
    private string _id;

    [ObservableProperty]
    private string? _svgIcon;

    [ObservableProperty]
    private string? _styleIcon;

    [ObservableProperty]
    private string _name;

    [ObservableProperty]
    private ObservableCollection<NavigationItem> _navigationItems = [];

    [ObservableProperty]
    private bool _isExpanded;
}

public partial class NavigationLink : NavigationItem
{
    [ObservableProperty]
    private Cluster _cluster;

    [ObservableProperty]
    private Type _controlType;
}

public partial class ResourceNavigationLink : NavigationLink
{
    [ObservableProperty]
    private ICollection _objects;
}

public class NavigationItemComparer : IComparer<NavigationItem>
{
    public int Compare(NavigationItem? x, NavigationItem? y)
    {
        return x?.Name.CompareTo(y?.Name) ?? 0;
    }
}
