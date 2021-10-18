using System.Threading.Tasks;

namespace bSynchronization.Services
{
    public interface ISynchronizationService
    {
        ValueTask StartAsync();
        ValueTask SendAsync(string groupName, string message);
    }
}
