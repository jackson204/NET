using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqMockWhereDemo
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

            // var persons = from p in lists
            //     where p.Category =="鞋子"
            //     select p; 

            var persons = lists
                .Where(r => r.Category == "鞋子")
                .Select(p => p);

            foreach (var person in persons)
            {
                Console.WriteLine($"ProductName = {person.ProductName} , Number = {person.Number}");
            }
            var persons2 = lists.MyWhere(r => r.Category == "鞋子")
                .Select(p => p);

            var persons3 = lists.MyWhere(Func2)
                .Select(p => p);
            
            
            var persons4 = lists.Where(r => r.Category == "鞋子")
                .MySelect(p => p);

            Console.WriteLine(new string('*', 10));
            foreach (var person in persons2)
            {
                Console.WriteLine($"ProductName = {person.ProductName} , Number = {person.Number}");
            }

            var person1 = new Person();
            person1.ProductName = "AAA";
            person1.Category = "鞋子";
            var b = Func2(person1);
            Console.WriteLine(b);
            var person2 = new Person();
            person2.ProductName = "BBB";
            person2.Category = "BBB";
            var b1 = Func2(person2);
            Console.WriteLine(b1);
        }

        public static bool Func2(Person person)
        {
            return person.Category == "鞋子";
        }
    }

    public static class ListEx
    {
        public static IEnumerable<Person> MyWhere(this IEnumerable<Person> list, Func<Person, bool> func)
        {
            foreach (var person in list)
            {
                if (func.Invoke(person))

                    //(Person p)=>{return  p.Category == "鞋子"p}
                    // if (func(person))
                    // if (Program.Func2(person))
                {
                    yield return person;
                }
            }
        }

        public static IEnumerable<Person> MySelect(this IEnumerable<Person> list, Func<Person, Person> func)
        {
            foreach (var person in list)
            {
                //p=>p
                //(Person p)=>{return p}
                yield return func(person);
            }
        }
    }

    public class Person
    {
        public string ProductName { get; set; }

        public string Category { get; set; }

        public int Number { get; set; }
    }
}