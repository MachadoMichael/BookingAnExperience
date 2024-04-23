using BookingAnExperience.Resources.Contexts;
using Microsoft.EntityFrameworkCore;

namespace BookingAnExperience.Domains.Localizations
{
    public interface ILocalizationService
    {
        Task<List<Localization>> GetAllAsync();
        Task<Localization> GetByIdAsync(Guid id);
        Task AddAsync(Localization entity);
        Task UpdateAsync(Localization entity);
        Task DeleteAsync(Guid id);
    }

    public class LocalizationService : ILocalizationService
    {
        private readonly BookingAnExperienceContext _context;

        public LocalizationService(BookingAnExperienceContext context)
        {
            _context = context;
        }

        public async Task<List<Localization>> GetAllAsync()
        {
            return await _context.Localizations.ToListAsync();
        }

        public async Task<Localization> GetByIdAsync(Guid id)
        {
            return await _context.Localizations.FindAsync(id);
        }

        public async Task AddAsync(Localization newLocalization)
        {
            _context.Localizations.Add(newLocalization);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Localization updatedLocalization)
        {
            _context.Entry(updatedLocalization).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var person = await _context.Localizations.FindAsync(id);
            if (person is not null)
            {
                _context.Localizations.Remove(person);
                await _context.SaveChangesAsync();
            }
        }
    }
}
