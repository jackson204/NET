using System;
using System.Collections;

namespace HashTableDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var hashtable = new Hashtable();
            hashtable.Add("A", "ZZZ");
            hashtable.Add(1, true);
            hashtable.Add(false, 222);

            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine($"Key : {item.Key} Value {item.Value} ");
            }
        }
    }
}