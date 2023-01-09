using Microsoft.EntityFrameworkCore;

namespace EFCoreDemo01
{
    public class TestDbContext:DbContext
    {
        public DbSet<Book> Books { set; get; }
        public DbSet<Person> Persons { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;initial catalog=EFCore01;integrated security=True;MultipleActiveResultSets=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }
    }
}