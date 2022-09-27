using System;

namespace MethodDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var sum = Program.Sum(1,2);
            Console.WriteLine(sum);
            
        }

        private static int Sum(int i, int j)
        {
            return i + j;
        }
    }
}