using Microsoft.EntityFrameworkCore;
using KPIManagementApp.Models;  // Replace with your actual project name

namespace KPIManagementApp.Data  // Replace with your actual project name
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Add DbSet properties for your tables here
        // For example:
        // public DbSet<KpiItem> KpiItems { get; set; }
    }
}