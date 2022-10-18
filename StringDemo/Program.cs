using System;
using System.Diagnostics;
using System.Text;

namespace StringDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var hello = "Hello";
            var hello2 = "Hello";
            var hello3 = "Hello2";

            var result = string.Empty;
            var sb = new StringBuilder();

            //創建一個計時器
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            for(int i = 0; i < 10000000; i++)
            {
                sb.Append(i);

                // result += i;
            }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);

            if ("Hello".Equals("hello", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("same");
            }
            var a = "a b dfd _ +  ,, , = , ddd ";
            char[] chars = {' ', '_', '+', ',', '='};

            //切割;去除空白
            var newA = a.Split(chars, StringSplitOptions.RemoveEmptyEntries);

            //convert string array to string
            var format = string.Join(string.Empty, newA);
            Console.WriteLine(format);

            var s = "2008-08-08";
            var date = s.Split(new char[] {'-'}, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"{date[0]}年{date[1]}月{date[2]}日");
        }
    }
}