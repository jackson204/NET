using System.Collections.Generic;
using CodeFirstDemoOneToMany.Model;

namespace CodeFirstDemoOneToMany
{
    internal class Program
    {
        // 1 Grade to many students
        public static void Main(string[] args)
        {
            using (var db = new MyDbContext())
            {
                db.Grades.Add(new Grade()
                {
                    GradeName = "AAA",
                    Students = new List<Student>()
                    {
                        new Student()
                        {
                            Name = "BBB"
                        }
                    }
                });
                db.SaveChanges();
            }
        }
    }
}