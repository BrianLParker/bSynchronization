// ---------------------------------------------------------------
// Copyright (c) Brian Parker All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using Moq;
using Xunit;

namespace bSynchronization.Tests.Unit.Services
{
    public partial class SynchronizationServiceTests
    {
        [Fact]
        public async ValueTask ShouldStartHubConnectionAsync()
        {
            // given
            this.hubConnectionBrokerMock.Setup(source =>
                source.StartAsync())
                    .Verifiable();

            // when
            await this.synchronizationService.StartAsync();

            // then
            this.hubConnectionBrokerMock.Verify(hubConnection =>
                hubConnection.StartAsync(), Times.Once());

            this.hubConnectionBrokerMock.VerifyNoOtherCalls();
        }

        [Fact]
        public async ValueTask ShouldSendStringMessageToGroupAsync()
        {
            // given
            string groupName = GetRandomGroupName();
            string message = GetRandomMessage();
            string inputGroupName = groupName;
            string inputMessage = message;
            string expectedGroupName = inputGroupName;
            string expectedMessage = inputMessage;

            this.hubConnectionBrokerMock.Setup(hubConnectionBroker =>
                hubConnectionBroker.SendAsync(inputGroupName, inputMessage))
                    .Verifiable();

            // when
            await this.synchronizationService.SendAsync(inputGroupName, inputMessage);

            // then
            this.hubConnectionBrokerMock.Verify(hubConnection =>
               hubConnection.SendAsync(expectedGroupName, expectedMessage), Times.Once());

            this.hubConnectionBrokerMock.VerifyNoOtherCalls();
        }

        [Fact]
        public async ValueTask ShouldJoinHubConnectionToGroupAsync()
        {
            // given
            string groupName = GetRandomGroupName();
            string inputGroupName = groupName;
            string expectedGroupName = inputGroupName;

            this.hubConnectionBrokerMock.Setup(hubConnectionBroker =>
                hubConnectionBroker.JoinGroupAsync(inputGroupName))
                    .Verifiable();

            // when
            await this.synchronizationService.JoinGroupAsync(inputGroupName);

            // then
            this.hubConnectionBrokerMock.Verify(hubConnection =>
               hubConnection.JoinGroupAsync(expectedGroupName), Times.Once());

            this.hubConnectionBrokerMock.VerifyNoOtherCalls();
        }

        [Fact]
        public async ValueTask ShouldRemoveHubConnectionFromGroupAsync()
        {
            // given
            string groupName = GetRandomGroupName();
            string inputGroupName = groupName;
            string expectedGroupName = inputGroupName;

            this.hubConnectionBrokerMock.Setup(hubConnectionBroker =>
                hubConnectionBroker.LeaveGroupAsync(inputGroupName))
                    .Verifiable();

            // when
            await this.synchronizationService.LeaveGroupAsync(inputGroupName);

            // then
            this.hubConnectionBrokerMock.Verify(hubConnection =>
               hubConnection.LeaveGroupAsync(expectedGroupName), Times.Once());

            this.hubConnectionBrokerMock.VerifyNoOtherCalls();
        }
    }
}
