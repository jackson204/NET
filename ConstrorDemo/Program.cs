using System;
using System.Security.Permissions;

namespace ConstrorDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var student = new Student("BBB" );
            Console.WriteLine($"{student.Name} , {student.Age}");
        }
    }
}