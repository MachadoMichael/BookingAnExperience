using BookingAnExperience.Resources.Contexts;
using Microsoft.EntityFrameworkCore;

namespace BookingAnExperience.Domains.Users
{
    public interface IUserService
    {
        Task<List<User>> GetAllAsync();
        Task<User> GetByIdAsync(Guid id);
        Task AddAsync(User entity);
        Task UpdateAsync(User entity);
        Task DeleteAsync(Guid id);
    }

    public class UserService : IUserService
    {
        private readonly BookingAnExperienceContext _context;

        public UserService(BookingAnExperienceContext context)
        {
            _context = context;
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetByIdAsync(Guid id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task AddAsync(User newUser)
        {
            _context.Users.Add(newUser);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(User updatedUser)
        {
            _context.Entry(updatedUser).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var person = await _context.Users.FindAsync(id);
            if (person is not null)
            {
                _context.Users.Remove(person);
                await _context.SaveChangesAsync();
            }
        }
    }
}
