using System;
using System.CodeDom;

namespace OutDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Test(out var max, out var min);
            Console.WriteLine($"max {max}  min {min}");
            
            var tryParse = int.TryParse("123a" , out var s);

            Console.WriteLine($"tryParse {tryParse} , result {s}");
            
            
            var myTryParse = MyTryParse("123a", out var result);
            Console.WriteLine($"myTryParse {myTryParse} , result {result}");

           
        }

        private static bool MyTryParse(string input, out int result)
        {
            result = 0;
            try
            {
                result = int.Parse(input);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private static void Test(out int max, out int min)
        {
            max = 2;
            min = 1;
        }
    }
}