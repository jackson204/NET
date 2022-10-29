using System;
using System.Collections.Generic;

namespace DictionaryDemo
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      var dictionary = new Dictionary<int, string>()
      {
        {1,"AA"} ,
        {2,"B"},
      };
      foreach (KeyValuePair<int,string> pair in dictionary)
      {
        Console.WriteLine($"{pair.Key} , {pair.Value}");
      }
    }
  }
}