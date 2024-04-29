using BookingAnExperience.Context;
using Microsoft.EntityFrameworkCore;

namespace BookingAnExperience.Domains.Homes
{
    public interface IHomeService
    {
        Task<List<Home>> GetAllAsync();
        Task<Home> GetByIdAsync(Guid id);
        Task AddAsync(Home entity);
        Task UpdateAsync(Home entity);
        Task DeleteAsync(Guid id);
    }

    public class HomeService : IHomeService
    {
        private readonly BookingAnExperienceContext _context;

        public HomeService(BookingAnExperienceContext context)
        {
            _context = context;
        }

        public async Task<List<Home>> GetAllAsync()
        {
            return await _context.Homes.ToListAsync();
        }

        public async Task<Home> GetByIdAsync(Guid id)
        {
            return await _context.Homes.FindAsync(id);
        }

        public async Task AddAsync(Home newHome)
        {
            _context.Homes.Add(newHome);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Home updatedHome)
        {
            _context.Entry(updatedHome).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var person = await _context.Homes.FindAsync(id);
            if (person is not null)
            {
                _context.Homes.Remove(person);
                await _context.SaveChangesAsync();
            }
        }
    }
}
