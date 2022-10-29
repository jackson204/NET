using System;

namespace AbstractDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //狗狗會叫 貓咪也會叫
            Animal dog = new Dog();
            dog.Bark();
            var cat = new Cat();
            cat.Bark();
            
            // 抽象類不能被實例化
            // Animal animal = new Animal();
        }
    }

    internal class Cat : Animal
    {
        //子類繼承抽象類後，必續把父類的所有抽象成員都重寫
        public override void Bark()
        {
            Console.WriteLine("Cat");
        }

        public override string TestString(string name)
        {
            throw new NotImplementedException();
        }
    }

    //
    public abstract class Animal
    {
        //不能有任何的實作
        public abstract void Bark();

        public abstract string TestString(string name);
    }

    internal class Dog : Animal
    {
        public override void Bark()
        {
            Console.WriteLine("Dog ");
        }

        public override string TestString(string name)
        {
            throw new NotImplementedException();
        }
    }
}