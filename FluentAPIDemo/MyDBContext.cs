using System.Data.Entity;
using System.Reflection;

namespace FluentAPIDemo
{
    public partial class MyDbContext : DbContext
    {
        public MyDbContext()
            : base("name=MyDBEntities")
        {
        }

        public virtual DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly()); 

            // modelBuilder.Configurations.Add(new PersonConfig());
        }
    }
}