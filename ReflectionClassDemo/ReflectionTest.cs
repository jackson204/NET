using System;

namespace ReflectionClassDemo
{
    public class ReflectionTest
    {
        public ReflectionTest()
        {
            Console.WriteLine("CTOR");
        }

        public ReflectionTest(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
    }
}