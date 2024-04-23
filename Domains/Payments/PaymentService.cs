using BookingAnExperience.Resources.Contexts;
using Microsoft.EntityFrameworkCore;

namespace BookingAnExperience.Domains.Payments
{
    public interface IPaymentService
    {
        Task<List<Payment>> GetAllAsync();
        Task<Payment> GetByIdAsync(Guid id);
        Task AddAsync(Payment entity);
        Task UpdateAsync(Payment entity);
        Task DeleteAsync(Guid id);
    }

    public class PaymentService : IPaymentService
    {
        private readonly BookingAnExperienceContext _context;

        public PaymentService(BookingAnExperienceContext context)
        {
            _context = context;
        }

        public async Task<List<Payment>> GetAllAsync()
        {
            return await _context.Payments.ToListAsync();
        }

        public async Task<Payment> GetByIdAsync(Guid id)
        {
            return await _context.Payments.FindAsync(id);
        }

        public async Task AddAsync(Payment newPayment)
        {
            _context.Payments.Add(newPayment);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Payment updatedPayment)
        {
            _context.Entry(updatedPayment).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var person = await _context.Payments.FindAsync(id);
            if (person is not null)
            {
                _context.Payments.Remove(person);
                await _context.SaveChangesAsync();
            }
        }
    }
}
