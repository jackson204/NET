using System;

namespace BreakDemo
{
    internal class Program
    {
        /// <summary>
        /// while 跳出當前循環 
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            int i = 1;
            int j = 1;
            while(i < 10)
            {
                while(j < 10)
                {
                    Console.WriteLine("in");
                    j++;
                    break;
                }
                Console.WriteLine("out");
                i++;
            }
        }
    }
}