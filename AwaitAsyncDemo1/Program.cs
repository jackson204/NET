using System;
using System.IO;

namespace AwaitAsyncDemo1
{
    class Program
    {
        //Main() 不支持異部方法 使用Result
        static void Main(string[] args)
        {
            var fileName = @"C:\Users\s9740\Desktop\test.txt";
            var readAllTextAsync = File.ReadAllTextAsync(fileName).Result;
            Console.WriteLine(readAllTextAsync);
        }
    }
}