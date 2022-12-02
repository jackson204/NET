using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;

namespace FluentAPIDemo
{
    public class PersonConfig:EntityTypeConfiguration<Person>
    {
        public PersonConfig()
        {
            //情境一:  沒有事先建立DB表 mssql 會幫自動建立同名的 
            //ToTable("Person");
        }
    }
}