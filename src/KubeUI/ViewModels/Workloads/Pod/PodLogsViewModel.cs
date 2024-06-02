﻿using System;
using System.IO;
using AvaloniaEdit.Document;
using CommunityToolkit.Mvvm.ComponentModel;
using k8s.Models;
using k8s;
using System.Threading.Tasks;
using Avalonia.Threading;

namespace KubeUI.ViewModels;

public sealed partial class PodLogsViewModel : ViewModelBase, IDisposable
{
    [ObservableProperty]
    private Client.Cluster _cluster;

    [ObservableProperty]
    private V1Pod _object;

    [ObservableProperty]
    private string _containerName;

    [ObservableProperty]
    private TextDocument _logs = new();

    [ObservableProperty]
    private bool _previous;

    private Stream? _stream;

    private StreamReader? _streamReader;

    private readonly int _lines = 1000;

    private bool _isConnected;

    public async Task Connect()
    {
        _stream = await Cluster!.Client!.CoreV1.ReadNamespacedPodLogAsync(Object.Name(), Object.Namespace(), container: ContainerName, tailLines: _lines, previous: Previous, follow: true, pretty: true);

        _streamReader = new StreamReader(_stream);

        _isConnected = true;

        _ = Task.Run(async () =>
        {
            while (_isConnected)
            {
                try
                {
                    var log = await _streamReader.ReadLineAsync();

                    if (!string.IsNullOrEmpty(log))
                    {
                        await Dispatcher.UIThread.InvokeAsync(() => Logs.Insert(Logs.TextLength, log + Environment.NewLine));
                    }
                }
                catch (IOException ex) when (ex.Message.Equals("The request was aborted."))
                {
                    _isConnected = false;

                    break;
                }
                catch (ObjectDisposedException)
                {
                    _isConnected = false;

                    break;
                }
            }
        });
    }

    public void Dispose()
    {
        _isConnected = false;

        _stream?.Dispose();

        _streamReader?.Dispose();
    }
}
