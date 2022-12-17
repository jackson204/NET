using CodeFirstDemoOneToOne.Model;

namespace CodeFirstDemoOneToOne
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            using (var db = new MyDbContext())
            {
                db.Students.Add(new Student()
                {
                    Name = "AAA",
                });
                db.SaveChanges();
            }
        }
    }
}