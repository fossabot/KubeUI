﻿using k8s;
using k8s.Models;
using KubeUI.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.ComponentModel;
using System.Threading.Tasks;

namespace KubeUI2.Pages
{
    [Route("/Node/{Name}")]
    public partial class Node : IDisposable
    {
        [Parameter] public string Name { get; set; }

        [Inject] protected IState State { get; set; }

        [Inject] protected IKubernetes Client { get; set; }

        private V1Node Item { get; set; }

        private PropertyChangedEventHandler handler;

        protected override async Task OnInitializedAsync()
        {
            handler = async (xo, e) =>
            {
                if (e.PropertyName == KubeUI.Services.State.UILevelNotification || e.PropertyName == KubeUI.Services.State.NamespaceNotification)
                {
                    await Update();
                }
            };

            State.PropertyChanged += handler;

            await Update();
        }

        public void Dispose()
        {
            State.PropertyChanged -= handler;
        }

        private async Task Update()
        {
            Item = await Client.ReadNodeAsync(Name);

            StateHasChanged();
        }
    }
}
