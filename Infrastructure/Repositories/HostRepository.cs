using Infrastructure.Persistence;
using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Infrastructure.Repositories
{
    public class HostRepository : IHostRepository
    {
        private readonly ApplicationDbContext _context;

        public HostRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> AddHostAsync(Host host)
        {
            _context.Hosts.Add(host);
            await _context.SaveChangesAsync();
            return host.Id;
        }

        public async Task<IEnumerable<Host>> GetAllHostsAsync()
        {
            return await _context.Hosts.ToListAsync();
        }

        public async Task<Host> GetHostByIdAsync(int id)
        {
            return await _context.Hosts.FindAsync(id);
        }

        public async Task UpdateHostAsync(Host host)
        {
            _context.Entry(host).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteHostAsync(Guid id)
        {
            var host = await _context.Hosts.FindAsync(id);
            if (host != null)
            {
                _context.Hosts.Remove(host);
                await _context.SaveChangesAsync();
            }
        }
    }
}
