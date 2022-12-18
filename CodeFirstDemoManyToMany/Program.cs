using System.Collections.Generic;
using CodeFirstDemoManyToMany.Model;

namespace CodeFirstDemoManyToMany
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            using (var db = new MyDbContext())
            {
                List<Student> student = new List<Student>()
                {
                    new Student()
                    {
                        Courses = new List<Course>()
                        {
                            new Course()
                            {
                                CourseName = "CoursesTest"
                            }
                        },
                        StudentName = "test"
                    },
                    new Student()
                    {
                        StudentName = "test2"
                    },
                };
                db.Students.AddRange(student);
                db.SaveChanges();
            }
        }
    }
}