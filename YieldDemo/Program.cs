using System;
using System.Collections.Generic;

namespace YieldDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Good> list = new List<Good>()
            {
                new Good()
                {
                    Name = "Test1", Age = 10
                },
                new Good()
                {
                    Name = "Test2", Age = 20
                },
                new Good()
                {
                    Name = "Test3", Age = 30
                },
                new Good()
                {
                    Name = "Test4", Age = 40
                },
            };

           var item =  GetGood(list, 25);

           foreach (var good in item)
           {
               Console.WriteLine(good.Age);
           }
        }

        private static IEnumerable<Good> GetGood(List<Good> list, int age)
        {
            foreach (var item in list)
            {
                if (item.Age > age)
                {
                    yield return item;
                }
            }
        }
    }

    internal class Good
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }
}