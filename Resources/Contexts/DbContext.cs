using Microsoft.EntityFrameworkCore;
using BookingAnExperience.Users;
using BookingAnExperience.Appointments;
using BookingAnExperience.Localizations;
using BookingAnExperience.Homes;

namespace BookingAnExperience.Resources.Context
{
    public class BookingAnExperienceContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Appointment> Appoitments { get; set; }
        public DbSet<Localization> Localizations { get; set; }
        public DbSet<Home> Homes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>()
              .HasKey(a => a.Id);
        }
    }
}
