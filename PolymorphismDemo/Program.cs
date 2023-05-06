using System.Security.Principal;

namespace PolymorphismDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var korean = new Korean("Hello");
            var chinese = new Chinese("Hello");
            Person[] persons = { korean, chinese };
            foreach (var item in persons)
            {
                item.SayHello();
            }
        }
    }

    public class Person
    {
        private string _name;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public Person(string name)
        {
            this.Name = name;
        }

        public void SayHello()
        {
            System.Console.WriteLine($"Hello, Person");
        }
    }

    public class Chinese : Person
    {
        public Chinese(string name) : base(name)
        {
        }

        public void SayHello()
        {
            System.Console.WriteLine($"Hello, Chinese");
        }
    }

    public class Korean : Person
    {
        public Korean(string name) : base(name)
        {
        }

        public void SayHello()
        {
            System.Console.WriteLine($"Hello, Korean");
        }
    }
}