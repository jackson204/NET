using System.Data.Entity.ModelConfiguration;

namespace CodeFirstDemoOneToMany.Model
{
    public class GradeConfig : EntityTypeConfiguration<Grade>
    {
        public GradeConfig()
        {
           
            this.HasMany(g => g.Students)
                .WithRequired(s => s.CurrentGrade)
                .HasForeignKey(s => s.CurrentGradeId)
                .WillCascadeOnDelete();
        }
    }
}