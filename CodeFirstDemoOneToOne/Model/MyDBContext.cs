using System.Data.Entity;

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

    }
}