using System.Data.Entity.ModelConfiguration;

namespace CodeFirstDemoManyToMany.Model
{
    public class StudentConfig : EntityTypeConfiguration<Student>
    {
        public StudentConfig()
        {
            this.HasKey(r => r.StudentId);
            
            this.Property(r => r.StudentId).HasColumnName("StudentId333333333");
            
            HasMany(s => s.Courses)
                .WithMany(c => c.Students)
                .Map(cs =>
                {
                    //左右?
                    cs.MapLeftKey("StudentRefId444444444444");
                    cs.MapRightKey("CourseRefId555555555555");
                    cs.ToTable("StudentCourse");
                });
        }
    }
}