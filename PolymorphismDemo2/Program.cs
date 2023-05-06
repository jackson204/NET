using System;

namespace PolymorphismDemo2
{
    internal class Program
    {
        //當父類中的方法不知道如何實現的時候，可以將父類中的方法標記為abstract，將方法寫成抽象方法，子類中的方法標記為override
        public static void Main(string[] args)
        {
            Person person = new Teacher();
            person.SayHello();

            //狗狗會叫，貓咪也會叫
            Animal dog = new Dog();
            Animal cat = new Cat();
            dog.Bark();
            cat.Bark();

            Console.WriteLine(new string('*', 10));
            
            var circle = new Circle(10);
            var area = circle.GetArea();
            Console.WriteLine($"圓面積為{area}");
            var perimeter = circle.GetPerimeter();
            Console.WriteLine($"圓周長為{perimeter}");
        }

        public abstract class Animal
        {
            public abstract void Bark();
        }

        public class Dog : Animal
        {
            public override void Bark()
            {
                Console.WriteLine("汪汪汪");
            }
        }

        public class Cat : Animal
        {
            public override void Bark()
            {
                Console.WriteLine("喵喵喵");
            }
        }
    }

    public class Person
    {
        public void SayHello()
        {
            Console.WriteLine("Person Hello");
        }
    }

    public class Teacher : Person
    {
        public void SayHello()
        {
            Console.WriteLine("老師好");
        }
    }
    public abstract class Shape
    {
        public abstract double GetArea();
        public abstract double GetPerimeter();
    }
    public class Circle : Shape
    {
        private double _radius;

        public double Radius
        {
            get => _radius;
            set => _radius = value;
        }

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
    
}