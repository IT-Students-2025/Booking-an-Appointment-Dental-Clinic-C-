using Booking_an_Appointment_Dental_Clinic.Models;
using System.Data.Entity;

namespace Booking_an_Appointment_Dental_Clinic.Data
{
    public class BookingContext : DbContext
    {
        public BookingContext() : base("BookingDB")
        {
        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}