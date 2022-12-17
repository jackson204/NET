using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Configuration;

namespace CodeFirstDemoOneToOne.Model
{
    public partial class MyDbContext : DbContext
    {
        public MyDbContext()
            : base("name=SchoolDB")
        {
        }

        public virtual DbSet<Student> Students { get; set; }

        public virtual DbSet<StudentAddress>StudentAddresses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new StudentConfig());
            modelBuilder.Configurations.Add(new StudentAddressConfig());
        }
    }
}