using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1
{
    internal class Context:DbContext
    {
        public DbSet<User> Users { get; set; }

        public Context()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Users.db;Trusted_Connection=True;");
        }
    }
}
