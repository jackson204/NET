using System;
using System.Linq;

namespace FirstLINQToObjectDemo
{
    internal class Program
    {
        // LINQ To Objects : Objects 指的就是物件集，只要是實作 IEnumerable介面的物件 都可以成為 LINQ To Objects 的資料來源
        public static void Main(string[] args)
        {
            string[] lists = new string[]
            {
                "code6421",
                "tom",
                "david"
            };
            var result = from s1 in lists
                      where s1 == "code6421"
                      select s1;
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}