using System;

namespace TryCatchDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("請輸入數字");
            var readLine = Console.ReadLine();
            var b = true;
            var input = 0;
            try
            {
                //語法上沒有錯誤，在運行中，某些原因出現了錯誤，不能運行
                input = Convert.ToInt32(readLine);
             
            }
            catch (Exception e)
            {
                Console.WriteLine($"不能轉為數字 {e.Message}");
                b = false;
            }
            if (b)
            {
                Console.WriteLine($"數字 {input}");
            }
           
        }
    }
}