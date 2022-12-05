using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqGroupByDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IEnumerable<Person> lists = new List<Person>()
            {
                new Person() {ProductName = "A", Category = "鞋子", Number = 100},
                new Person() {ProductName = "B", Category = "八仙子", Number = 90},
                new Person() {ProductName = "C", Category = "八仙子", Number = 80},
                new Person() {ProductName = "D", Category = "鞋子", Number = 70},
                new Person() {ProductName = "E", Category = "鞋子", Number = 60},
                new Person() {ProductName = "F", Category = "八仙子", Number = 50},
                new Person() {ProductName = "G", Category = "鞋子", Number = 40},
            };

            IEnumerable<IGrouping<string, Person>> result = from p in lists
                                                            group p by p.Category;

            foreach (IGrouping<string, Person> grouping in result)
            {
                Console.WriteLine($"Category is {grouping.Key} , count {grouping.Count()} ");
                foreach (Person person in grouping)
                {
                    Console.WriteLine($"ProductName = {person.ProductName} , Number = {person.Number}");
                }
            }
            var result2 = from p in lists
                          group p by p.Category into g
                          select new {Title = g.Key, Num = g.Count()};

            foreach (var item in result2)
            {
                Console.WriteLine($"{item.Title} , {item.Num}");
            }
        }
    }
}