using System.Data.Entity;

namespace CodeFirstDemo.Model
{
    public partial class MyDbContext : DbContext
    {
        public MyDbContext()
            : base("name=MyDBEntities")
        {
        }

        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
          
            modelBuilder.Configurations.Add(new UserConfig());
            modelBuilder.Configurations.Add(new OrderConfig());
        }
    }
}