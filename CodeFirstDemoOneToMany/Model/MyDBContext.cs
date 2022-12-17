using System.Data.Entity;

namespace CodeFirstDemoOneToMany.Model
{
    public partial class MyDbContext : DbContext
    {
        public MyDbContext()
            : base("name=SchoolDB2")
        {
        }

        public virtual DbSet<Student> Students { get; set; }

        public virtual DbSet<Grade> Grades { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new StudentConfig());
            modelBuilder.Configurations.Add(new GradeConfig());
        }
    }
}