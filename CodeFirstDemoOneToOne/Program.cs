using CodeFirstDemoOneToOne.Model;

namespace CodeFirstDemoOneToOne
{
    internal class Program
    {
        // https: //www.entityframeworktutorial.net/code-first/configure-one-to-one-relationship-in-code-first.aspx
        public static void Main(string[] args)
        {
            using (var db = new MyDbContext())
            {
                db.Students.Add(new Student()
                {
                    Name = "AAA",
                    StudentAddress = new StudentAddress()
                    {
                        Address = "VVV"
                    }
                });
                db.SaveChanges();
            }
        }
    }
}