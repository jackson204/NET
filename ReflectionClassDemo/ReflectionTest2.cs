using System;

namespace ReflectionClassDemo
{
    public class ReflectionTest2
    {
        private ReflectionTest2()
        {
            Console.WriteLine("private CTOR");
        }

        public void Show()
        {
            Console.WriteLine($"public Show {nameof(ReflectionTest2)}");
        }
        private void Show2()
        {
            Console.WriteLine($"private Show2 {nameof(ReflectionTest2)}");
        }
    }
}