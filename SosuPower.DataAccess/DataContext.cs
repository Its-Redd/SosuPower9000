using Microsoft.EntityFrameworkCore;
using SosuPower.Entities;

namespace SosuPower.DataAccess
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public DbSet<CareCenter> CareCenters { get; set; }
        public DbSet<Resident> Residents { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Diagnosis> Diagnoses { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<SoUs.Entities.Task> Tasks { get; set; }
        public DbSet<Employee> Employees { get; set; }

    }
}
