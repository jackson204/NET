using System;
using System.Security.AccessControl;

namespace AccessModifierDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var person = new Person();
        }
    }

    public class Person
    {
        // 子類可以訪問的到
        protected string _name;

        public string Name
        {
            get => _name;
            set => _name = value;
        }
    }

    public class Student : Person
    {
        public void Test()
        {
            Console.WriteLine(this._name);
        }
    }
}