using Microsoft.EntityFrameworkCore;
using Models;

namespace Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=LocalDataBase_auth;Username=postgres;Password=1111");
        //}
    }
}
