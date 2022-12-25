using System;
using System.IO;
using System.Threading.Tasks;

namespace AwaitAsyncDemo3
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var result = await ReadFileAsync(1);
            Console.WriteLine(result);
        }

        //沒有async的異步方法
        private static Task<string> ReadFileAsync(int i)
        {
            if (i ==1)
            {
                return File.ReadAllTextAsync(@"C:\Users\s9740\Desktop\test.txt");
            }
            throw new Exception();
        }
    }
}