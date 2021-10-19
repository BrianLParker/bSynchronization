// ---------------------------------------------------------------
// Copyright (c) Brian Parker All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;

namespace bSynchronization.Brokers.HubConnections
{

    public class HubConnectionBroker : IHubConnectionBroker
    {
        private readonly HubConnection hubConnection;

        public HubConnectionBroker(HubConnection hubConnection) => this.hubConnection = hubConnection;

        public HubConnectionState State { get; }
        public Action<string> OnReceiveMessage { get; set; }
        public Action<HubConnectionState> OnStatusChanged { get; set; }

        public ValueTask StartAsync() =>
            throw new NotImplementedException();
        public ValueTask JoinGroupAsync(string groupName) =>
            throw new NotImplementedException();
        public ValueTask LeaveGroupAsync(string groupName) =>
            throw new NotImplementedException();
        public ValueTask SendAsync(string groupName, string message) =>
            throw new NotImplementedException();
        public ValueTask DisposeAsync() =>
            throw new NotImplementedException();
    }
}
