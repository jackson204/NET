using System;

namespace StaticAndNonStatic
{
    public static class Student{
        
        private static string _name;

        public static string Name
        {
            get => _name;
            set => _name = value;
        }

        public static void M3()
        {
            Console.WriteLine("Static Class");
        }
    }
}