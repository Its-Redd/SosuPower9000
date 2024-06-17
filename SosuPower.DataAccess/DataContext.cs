using Microsoft.EntityFrameworkCore;
using SosuPower.Entities;

namespace SosuPower.DataAccess
{
    public class DataContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataContext"/> class.
        /// </summary>
        /// <param name="options">The options for configuring the data context.</param>
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        /// <summary>
        /// Configures the model for the data context.
        /// </summary>
        /// <param name="modelBuilder">The model builder.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<CareCenter> CareCenters { get; set; }
        public DbSet<Resident> Residents { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Diagnosis> Diagnoses { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Entities.Task> Tasks { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<SubTask> SubTasks { get; set; }
        public DbSet<MedicineTask> MedicineTasks { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
