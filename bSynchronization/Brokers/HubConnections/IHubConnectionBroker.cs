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
    public interface IHubConnectionBroker
    {
        ValueTask StartAsync();
        HubConnectionState State { get; }
        Action<string> OnReceiveMessage { get; }
        Action<HubConnectionState> OnStatusChanged { get; }
        ValueTask SendAsync(string groupName, string message);
        ValueTask JoinGroupAsync(string groupName);
        ValueTask LeaveGroupAsync(string groupName);
        ValueTask DisposeAsync();
    }
}
