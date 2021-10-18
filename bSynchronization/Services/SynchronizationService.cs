﻿using System;
using System.Threading.Tasks;
using bSynchronization.Brokers.HubConnections;

namespace bSynchronization.Services
{
    public class SynchronizationService : ISynchronizationService
    {
        private readonly IHubConnectionBroker hubConnectionBroker;

        public SynchronizationService(IHubConnectionBroker hubConnectionBroker)
        {
            this.hubConnectionBroker = hubConnectionBroker;
        }

        public async ValueTask StartAsync() =>
            await this.hubConnectionBroker.StartAsync();
    }
}
