using System;

namespace InheritanceDemo
{
    internal class Student : Person
    {
        public int Id { get; set; }

        public string Study()
        {
            return "Study";
        }

        public Student(string name, int age, char gender, int id)
            : base(name, age, gender)
        {
            Id = id;
        }

        //new 隱藏從父類那裏繼承過來的成員
        public new void SayHello()
        {
            Console.WriteLine("Student Hello");
        }
    }
}