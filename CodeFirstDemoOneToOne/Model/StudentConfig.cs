using System.Data.Entity.ModelConfiguration;

namespace CodeFirstDemoOneToOne.Model
{
    public class StudentConfig : EntityTypeConfiguration<Student>
    {
        public StudentConfig()
        {
            this.ToTable("Student");

            //PK
            this.HasKey(r => r.StudentId);

            this.Property(r => r.StudentId)
                .HasColumnName("StudentId");

            this.Property(r => r.Name)
                .HasColumnName("StudentName") //table Column
                .HasColumnType("nvarchar")//table type
                .HasMaxLength(50) //長度
                .IsRequired();    //允不允許null

            this.HasRequired(s => s.StudentAddress)
                .WithRequiredPrincipal(ad => ad.Student);
        }
    }
}