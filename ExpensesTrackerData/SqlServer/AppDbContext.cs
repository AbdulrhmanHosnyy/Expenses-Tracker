using ExpensesTrackerCore;
using Microsoft.EntityFrameworkCore;

namespace ExpensesTrackerData.SqlServer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {

        }
        //  Tables:
        public DbSet<Category> Categories { get; set; }
        public DbSet<SystemRecord> SystemRecords { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Outcome> Outcomes { get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserPermission> UserPermissions { get; set; }




        //  Set connection string:
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var connectionString = "Server = .\\SQLEXPRESS ; Database = ExpensesTracker ; " +
                "Integrated Security = SSPI ; TrustServerCertificate = True";
            optionsBuilder.UseSqlServer(connectionString);
        }

    }
}
