using System;
using System.Collections;

namespace ArrayListDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var arrayList = new ArrayList
            {
                1,
                true,
                "test",
                new Person()
            };
            foreach (var item in arrayList)
            {
                if (item is Person person)
                {
                    person.SayHello();
                }
                else
                {
                    Console.WriteLine(item);
                }
            }
        }
    }

    internal class Person
    {
        public void SayHello()
        {
            Console.WriteLine("Hello");
        }
    }
}