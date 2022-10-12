using System;
using System.Security.Principal;

namespace StaticAndNonStatic
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var person = new Person();
            person.M1();
            Person.M2();
            Student.M3();
        }
    }

    internal class Person
    {
        public void M1()
        {
            Console.WriteLine("non static");
        }

        public static void M2()
        {
            Console.WriteLine("Static");
        }
    }
    public static class Student{
        
        private static string _name;

        public static string Name
        {
            get => _name;
            set => _name = value;
        }

        public static void M3()
        {
            Console.WriteLine("Static Class");
        }
    }
}