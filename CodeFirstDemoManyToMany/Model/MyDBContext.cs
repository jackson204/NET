using System.Data.Entity;

namespace CodeFirstDemoManyToMany.Model
{
    public partial class MyDbContext : DbContext
    {
        public MyDbContext()
            : base("name=SchoolDB3")
        {
        }

        public virtual DbSet<Student> Students { get; set; }

        public virtual DbSet<Course> Grades { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new StudentConfig());
            modelBuilder.Configurations.Add(new CourseConfig());
        }
    }
}