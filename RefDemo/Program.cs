using System;
using System.Net.Sockets;

namespace RefDemo
{
    internal class Program
    {
        // ref 能將一個變量帶入一個方法中進行改變，改變完成後 在將改變後的值 帶出方法
        public static void Main(string[] args)
        {
            int a = 100;
            Add(a);
            Console.WriteLine(a);
            Add(ref a);
            Console.WriteLine(a);
        }

        private static void Add(int i)
        {
            i += 50;
        }
        private static void Add(ref int i)
        {
            i += 50;
        }
    }
}