
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace ExecuteSqlCommandDemo
{
    public partial class MyDbContext : DbContext
    {
        public MyDbContext()
            : base("name=MyDBEntities2")
        {
        }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}