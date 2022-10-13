using System;

namespace ConstrorDemo
{
    internal class Student
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            Console.WriteLine("(name , age )");
        }
        public Student(string name):this(name,10)
        {
            Console.WriteLine("name");
        }
    }
}