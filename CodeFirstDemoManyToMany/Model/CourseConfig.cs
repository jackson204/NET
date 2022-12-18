using System.Data.Entity.ModelConfiguration;

namespace CodeFirstDemoManyToMany.Model
{
    public class CourseConfig : EntityTypeConfiguration<Course>
    {
        public CourseConfig()
        {
            this.HasKey(r => r.CourseId);
            this.Property(r => r.CourseId).HasColumnName("CourseId222222");
        }
    }
}