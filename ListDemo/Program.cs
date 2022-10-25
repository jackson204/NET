using System;
using System.Collections;

namespace ListDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(true);
            arrayList.Add(new int[] {1, 2, 3, 4});
            var person = new Person();
            arrayList.Add(person);
            foreach (var item in arrayList)
            {
                if (item is Person person1)
                {
                    person1.SayHello();
                }
                else if (item is int[] ints)
                {
                    for(var index = 0; index < ints.Length; index++)
                    {
                        var t = ints[index];
                        Console.WriteLine(t);
                    }
                }
                else
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine("*****************");
            var list = new ArrayList();
            //添加單一元素
            list.Add(2);
            //添加集合元素
            list.AddRange(new int[] {5, 6, 7, 8});
            foreach (var item2 in list)
            {
                Console.WriteLine(item2);
            }
        }
    }
}