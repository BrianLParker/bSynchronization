// ---------------------------------------------------------------
// Copyright (c) Brian Parker All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using System.Threading.Tasks;
using bSynchronization.Brokers.HubConnections;

namespace bSynchronization.Services
{
    public class SynchronizationService : ISynchronizationService
    {
        private readonly IHubConnectionBroker hubConnectionBroker;

        public SynchronizationService(IHubConnectionBroker hubConnectionBroker) =>
            this.hubConnectionBroker = hubConnectionBroker;

        public async ValueTask JoinGroupAsync(string groupName) =>
            await hubConnectionBroker.JoinGroupAsync(groupName);

        public async ValueTask SendAsync(string groupName, string message) =>
            await this.hubConnectionBroker.SendAsync(groupName, message);

        public async ValueTask StartAsync() =>
            await this.hubConnectionBroker.StartAsync();
    }
}
