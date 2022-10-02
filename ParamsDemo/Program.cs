using System;
using System.CodeDom;

namespace ParamsDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var result = Sum(1,2);
            Console.WriteLine(result);
            var result2 = Sum(1,2,3,4);
            Console.WriteLine(result2);
        }

        private static int Sum(params int[] lists)
        {
            int result = 0;
            for(int i = 0; i < lists.Length; i++)
            {
                 result += lists[i];
            }
            return result;
        }
    }
}