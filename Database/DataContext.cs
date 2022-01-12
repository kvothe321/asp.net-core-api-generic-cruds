using Microsoft.EntityFrameworkCore;
using MyHealth.Models;

namespace MyHealth.Database
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options)
           : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
