using System;
using System.Collections.Generic;

namespace CacheDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Console.WriteLine(Factorial.CalculateFactorial(2));

            Console.WriteLine(Factorial.GetFactorial(5));
            Console.WriteLine(Factorial.GetFactorial(5));
            Console.WriteLine(Factorial.GetFactorial(6));
            Console.WriteLine(Factorial.GetFactorial(6));
        }
    }

    internal class Factorial
    {
        private static readonly Dictionary<int, int> _cache = new Dictionary<int, int>();

        public static int GetFactorial(int number)
        {
            if (!_cache.ContainsKey(number))
            {
                int result = CalculateFactorial(number);
                _cache[number] = result;
                return result;
            }
            return _cache[number];
        }

        public static int CalculateFactorial(int number)
        {
            int result = 1;
            for(int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}