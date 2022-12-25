using System;
using System.IO;
using System.Threading.Tasks;

namespace AwaitAsyncDemo4
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var t1 = File.ReadAllTextAsync(@"C:\Users\s9740\Desktop\test.txt");
            var t2 = File.ReadAllTextAsync(@"C:\Users\s9740\Desktop\test.txt");
            var t3 = File.ReadAllTextAsync(@"C:\Users\s9740\Desktop\test.txt");
            var task = await Task.WhenAll(t1,t2,t3);
            Console.WriteLine(task[0]);
        }
    }
}