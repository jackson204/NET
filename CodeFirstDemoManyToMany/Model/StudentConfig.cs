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
                    cs.MapLeftKey("StudentRefId444444444444");//當前主題是誰 EX:Student 
                    cs.MapRightKey("CourseRefId555555555555");//Course
                    cs.ToTable("StudentCourse");
                });
        }
    }
}