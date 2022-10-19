using System;

namespace InheritanceDemo
{
    internal class Person
    {
        // public Person()
        // {
        //     Console.WriteLine("Person CTOR");
        // }

        private int _age;
        private char _gender;
        private string _name;

        protected Person(string name, int age, char gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public int Age
        {
            get => _age;
            set => _age = value;
        }

        public char Gender
        {
            get => _gender;
            set => _gender = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public void Chcss()
        {
            Console.WriteLine("Person CHCSS");
        }
    }
}