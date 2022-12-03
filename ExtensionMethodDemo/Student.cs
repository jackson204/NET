using System;

namespace ExtensionMethodDemo
{
    public class Student
    {
        public string Name { get; set; }

        public int Age { get; set; }
        public void Show()
        {
            Console.WriteLine("Show");
        }

    }
}