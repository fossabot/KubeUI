﻿using k8s;
using k8s.Models;
using KubeUI.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;

namespace KubeUI2.Components
{
    public partial class DeploymentList : IDisposable
    {
        [Parameter]
        public string Namespace { get; set; }

        [Inject]
        protected IState state { get; set; }

        [Inject]
        protected IKubernetes client { get; set; }

        private IList<V1Deployment> Items { get; set; } = new List<V1Deployment>();

        private PropertyChangedEventHandler handler;

        protected override async Task OnInitializedAsync()
        {
            handler = async (xo, e) =>
            {
                if (e.PropertyName == State.UILevelNotification || e.PropertyName == State.NamespaceNotification)
                {
                    await Update();
                }
            };

            state.PropertyChanged += handler;

            await Update();
        }

        public void Dispose()
        {
            state.PropertyChanged -= handler;
        }

        private async Task Update()
        {
            Items = null;

            StateHasChanged();

            if (state.Namespace == null || state.Namespace.Equals(State.AllNameSpace))
            {
                Items = (await client.ListDeploymentForAllNamespacesAsync())?.Items;
            }
            else
            {
                Items = (await client.ListNamespacedDeploymentAsync(state.Namespace))?.Items;
            }

            StateHasChanged();
        }
    }
}
