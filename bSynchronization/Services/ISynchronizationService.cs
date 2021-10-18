using System.Threading.Tasks;

namespace bSynchronization.Services
{
    public interface ISynchronizationService
    {
        ValueTask StartAsync();
    }
}
