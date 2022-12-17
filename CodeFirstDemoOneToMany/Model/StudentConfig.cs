using System.Data.Entity.ModelConfiguration;

namespace CodeFirstDemoOneToMany.Model
{
    public class StudentConfig : EntityTypeConfiguration<Student>
    {
        public StudentConfig()
        {
            // this.Property(r => r.CurrentGradeId).HasColumnName("GradeId");
        }
    }
}