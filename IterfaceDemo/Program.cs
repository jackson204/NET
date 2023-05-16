using System;

namespace IterfaceDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IFlyable bird = new Bird();
            bird.Fly();
        }
    }

    public interface IFlyable
    {
        void Fly();
    }

    public class Person : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Person Fly");
        }
    }

    public class Bird : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Bird Fly");
        }
    }
}