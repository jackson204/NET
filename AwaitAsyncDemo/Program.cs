using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AwaitAsyncDemo
{
    class Program
    {
        // 1.異步方法的返回值一般是Task<T>, T是真正的返回值類型
        // 2.有 await 方法必須修視為 async
        static async Task Main(string[] args)
        {
            #region Demo1

            //
            var fileName = @"C:\Users\s9740\Desktop\test.txt";
            //
            // var sb = new StringBuilder();
            // for(var i = 0; i < 10000; i++)
            // {
            //     sb.AppendLine(i + "Hello");
            // }
            //
            // //File.WriteAllTextAsync(fileName, sb.ToString());
            // await File.WriteAllTextAsync(fileName, sb.ToString());
            // var readAllTextAsync = await File.ReadAllTextAsync(fileName);
            // Console.WriteLine(readAllTextAsync);

            #endregion

            #region MyRegion

            // await DownLoadHtmlAsync("https://tw.yahoo.com/", fileName);
            // Console.WriteLine("ok");
            #endregion
        }

        private static async Task DownLoadHtmlAsync(string url, string fileName)
        {
            using var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(url);
            await File.WriteAllTextAsync(fileName, html);
        }
    }
}