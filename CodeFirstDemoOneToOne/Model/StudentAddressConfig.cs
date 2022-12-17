using System.Data.Entity.ModelConfiguration;

namespace CodeFirstDemoOneToOne.Model
{
    public class StudentAddressConfig : EntityTypeConfiguration<StudentAddress>
    {
        public StudentAddressConfig()
        {
            this.ToTable("StudentAddress");
            
            this.Property(r => r.StudentAddressId).HasColumnName("StudentAddressId");
            this.Property(r => r.Address).HasColumnName("Column_AddressId");
        }
    }
}