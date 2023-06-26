using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services
{
    public class ProducersService : IProducersService
    {
        private readonly AppDbContext _context;

        public ProducersService(AppDbContext context)
        {
            _context = context;

        }

        public async Task AddAsync(Producer producer) { 
            await _context.Producers.AddAsync(producer);
            await _context.SaveChangesAsync();

        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Producers.FirstOrDefaultAsync(x => x.Id == id);
            _context.Producers.Remove(result);
            await _context.SaveChangesAsync();

        }

        public async Task<IEnumerable<Producer>> GetAllAsync()
        {
            var allProducers = await _context.Producers.ToListAsync();
            return allProducers;

        }

        public async Task<Producer> GetByIdAsync(int id)
        {
            var result = await _context.Producers.FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }

        public async Task<Producer> UpdateAsync(int id, Producer producer)
        {
            _context.Update(producer);
            await _context.SaveChangesAsync();
            return producer;


        }
    }
}
