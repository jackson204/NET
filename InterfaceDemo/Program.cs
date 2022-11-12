using System;

namespace InterfaceDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IFlyable person = new Person();
            person.Name = "set Name";
            person.Fly();
            IFlyable bird = new Bird();
            bird.Fly();
        }
    }

    public class Bird : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Bird Fly");
        }

        public string Test()
        {
            throw new NotImplementedException();
        }

        public string Name { get; set; }
    }

    public class Person : IFlyable
    {
        private string _AA;

        public void Fly()
        {
            Console.WriteLine($"Person fly , {this.Name}");
        }

        public string Test()
        {
            throw new NotImplementedException();
        }

        public string Name
        {
            get => _AA;
            set => _AA = value;
        }
    }

    public interface IFlyable
    {
        //接口成員不允許添加存取修飾符，默認就是public
        void Fly();

        //方法
        string Test();

        //自動屬性
        string Name { get; set; }
    }
}