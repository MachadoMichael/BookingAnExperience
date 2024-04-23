using BookingAnExperience.Resources.Contexts;
using Microsoft.EntityFrameworkCore;

namespace BookingAnExperience.Domains.Appointments
{
    public interface IAppointmentService
    {
        Task<List<Appointment>> GetAllAsync();
        Task<Appointment> GetByIdAsync(Guid id);
        Task AddAsync(Appointment entity);
        Task UpdateAsync(Appointment entity);
        Task DeleteAsync(Guid id);
    }

    public class AppointmentService : IAppointmentService
    {
        private readonly BookingAnExperienceContext _context;

        public AppointmentService(BookingAnExperienceContext context)
        {
            _context = context;
        }

        public async Task<List<Appointment>> GetAllAsync()
        {
            return await _context.Appointments.ToListAsync();
        }

        public async Task<Appointment> GetByIdAsync(Guid id)
        {
            return await _context.Appointments.FindAsync(id) ?? null;
        }

        public async Task AddAsync(Appointment newAppointment)
        {
            _context.Appointments.Add(newAppointment);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Appointment updatedAppointment)
        {
            _context.Entry(updatedAppointment).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var person = await _context.Appointments.FindAsync(id);
            if (person is not null)
            {
                _context.Appointments.Remove(person);
                await _context.SaveChangesAsync();
            }
        }
    }
}
