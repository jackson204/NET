using System.Linq;
using EntityStateDemo.Model;

namespace EntityStateDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            using (var db = new MyDbContext())
            {
                var user = db.Users.FirstOrDefault(r=>r.Id==1);
                user.Email = "BBBB";
                var dbEntityEntry = db.Entry(user);
                var originalValue = dbEntityEntry.OriginalValues["Email"];
                var currentValue = dbEntityEntry.CurrentValues["Email"];
                
                
            }
        }
    }
}