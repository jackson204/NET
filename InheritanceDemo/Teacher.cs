using System;

namespace InheritanceDemo
{
    internal class Teacher : Person
    {
      
        public int Salary { get; set; }
        public string Teach()
        {
            return "Teach";
        }

        public Teacher(string name, int age, char gender,int salary)
            : base(name, age, gender)
        {
            Salary = salary;
        }
    }
}