// ---------------------------------------------------------------
// Copyright (c) Brian Parker All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using System.Threading.Tasks;

namespace bSynchronization.Services
{
    public interface ISynchronizationService
    {
        ValueTask StartAsync();
        ValueTask SendAsync(string groupName, string message);
        ValueTask JoinGroupAsync(string groupName);
        ValueTask LeaveGroupAsync(string groupName);
    }
}
