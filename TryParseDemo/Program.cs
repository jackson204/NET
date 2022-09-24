using System;

namespace TryParseDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //使用Convert 進行轉換 ，失敗就掏 "異常"  Convert.ToInt32 內部使用就是用int.Parse
            // var numberOne = Convert.ToInt32("123a");
            //另一種寫法
            // var numberOne = int.Parse("123a");

            int result = 100;
            Console.WriteLine($"result 初始值 : {result}");           
            var b = int.TryParse("123a" , out  result );
            Console.WriteLine($"result {result}");           
            
            b = int.TryParse("123" , out  result );
            Console.WriteLine( b);
            Console.WriteLine($"result {result}");           
            
        }
    }
}