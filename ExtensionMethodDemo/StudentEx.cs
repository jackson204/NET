using System;

namespace ExtensionMethodDemo
{
    public static class StudentEx
    {
        // this Student student 指名這個擴充方法是為了這個類所提供的
        public static void  Run(this Student student)
        {
            Console.WriteLine("Run");
        }

        public static void ShowMyself(this Student student, string name  , int age) 
        {
            student.Name = name;
            student.Age = age;
            Console.WriteLine($"{student.Name} {student.Age}");
        }
    }
}