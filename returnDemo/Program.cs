using System;

namespace ReturnDemo
{
    internal class Program
    {
        //return
        // 1. 在方法中返回的值
        // 2. 立即結束本次的方法
        public static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Hello World");
               // break;
               // continue;
                return;
            }
            Console.WriteLine("end");
        }
    }
}