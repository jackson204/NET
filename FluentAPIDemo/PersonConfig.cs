using System.Data.Entity.ModelConfiguration;

namespace FluentAPIDemo
{
    public class PersonConfig:EntityTypeConfiguration<Person>
    {
        public PersonConfig()
        {
            ToTable("Person");
        }
    }
}