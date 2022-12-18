using System.Collections.Generic;

namespace CodeFirstDemoManyToMany.Model
{
    public class Student
    {  public Student() 
        {
            this.Courses = new HashSet<Course>();
        }
        public int StudentId { get; set; }
        
        public string StudentName { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}