using System;

namespace StaticAndNonStatic
{
    internal class Person
    {
        private static string _name;

        public static string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        private int _age;
        public void M1()
        {
            Console.WriteLine("non static");
        }

        public static void M2()
        {
            Console.WriteLine("Static");
        }
    }
}