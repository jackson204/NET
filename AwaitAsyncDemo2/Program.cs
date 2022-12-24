using System;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace AwaitAsyncDemo2
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("start  = " + Thread.CurrentThread.ManagedThreadId);
            // double r = await CalcAsync(500);
            double r = await CalcAsync2(500);
            Console.WriteLine($"r = {r}");
            Console.WriteLine("end = " + Thread.CurrentThread.ManagedThreadId);
        }

        private static async Task<double> CalcAsync(int n)
        {
            Console.WriteLine("CalcAsync = "+Thread.CurrentThread.ManagedThreadId);
            double result = 0;
            for(int i = 0; i < 10000000; i++)
            {
                result += i;
            }
            return result;
        }
        private static async Task<double> CalcAsync2(int n)
        {
            return await Task.Run(() =>
            {
                Console.WriteLine("CalcAsync = " + Thread.CurrentThread.ManagedThreadId);
                double result = 0;
                for(int i = 0; i < 10000000; i++)
                {
                    result += i;
                }
                return result;
            });

        }
    }
}