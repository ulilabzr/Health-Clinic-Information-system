using HEALTH_CLINIC_INFORMATION_SYSTEM.Model.Entity;
using Microsoft.EntityFrameworkCore;

namespace HEALTH_CLINIC_INFORMATION_SYSTEM.Model.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<UserModel> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;database=clinic1;user=root;password=",
                new MySqlServerVersion(new Version(8, 0, 30)));
        }
    }
}
