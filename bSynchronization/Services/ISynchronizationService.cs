using System.Threading.Tasks;

namespace bSynchronization.Services
{
    public interface ISynchronizationService
    {
        ValueTask StartAsync();
        void SendAsync(string groupName, string message);
    }
}
