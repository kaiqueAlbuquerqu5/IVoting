using Domain.Entities;

namespace Application.Interfaces
{
    public interface IHostRepository
    {
        Task<int> AddHostAsync(Host host);
        Task<Host> GetHostByIdAsync(int id);
        Task<IEnumerable<Host>> GetAllHostsAsync();
        Task UpdateHostAsync(Host host);
        Task DeleteHostAsync(Guid id);
    }
}
