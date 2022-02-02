using Microsoft.EntityFrameworkCore;
using UserService.Database.Entities;

namespace UserService.Database
{
    public class DatabaseContext: DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-8VTLERK\\SQLEXPRESS; database=microserviceDB; Trusted_Connection=true;MultipleActiveResultSets=true");
        }
    }
}
