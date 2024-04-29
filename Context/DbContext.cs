using BookingAnExperience.Domains.Appointments;
using BookingAnExperience.Domains.Homes;
using BookingAnExperience.Domains.Localizations;
using BookingAnExperience.Domains.Payments;
using BookingAnExperience.Domains.Users;
using Microsoft.EntityFrameworkCore;

namespace BookingAnExperience.Context
{
    public class BookingAnExperienceContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Localization> Localizations { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Home> Homes { get; set; }

        public BookingAnExperienceContext(DbContextOptions<BookingAnExperienceContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(u => u.Id);
            modelBuilder.Entity<Appointment>().HasKey(a => a.Id);
            modelBuilder.Entity<Home>().HasKey(h => h.Id);
        }
    }
}
