// ---------------------------------------------------------------
// Copyright (c) Brian Parker All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using bSynchronization.Brokers.HubConnections;
using bSynchronization.Services;
using Moq;
using Tynamix.ObjectFiller;

namespace bSynchronization.Tests.Unit.Services
{
    public partial class SynchronizationServiceTests
    {
        private readonly Mock<IHubConnectionBroker> hubConnectionBrokerMock;
        private readonly ISynchronizationService synchronizationService;

        public SynchronizationServiceTests()
        {
            this.hubConnectionBrokerMock = new Mock<IHubConnectionBroker>();

            this.synchronizationService = new SynchronizationService(
                hubConnectionBroker: this.hubConnectionBrokerMock.Object);
        }

        private static string GetRandomString() =>
            new MnemonicString().GetValue();
        private static string GetRandomMessage() =>
            GetRandomString();
        private static string GetRandomGroupName() =>
            GetRandomString();
    }
}
