using System;
using System.Security.Principal;

namespace PolymorphismDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var korean = new Korean("Hello");
            var chinese = new Chinese("Hello");
            var english = new English("Hello");
            Person[] persons = { korean, chinese, english };

            #region 使用 is 關鍵字判斷型別

            foreach (Person person in persons)
            {
                if (person is Chinese chinese1)
                {
                    chinese1.SayHello();
                }
                else if (person is Korean korean1)
                {
                    korean1.SayHello();
                }else if (person is English english1)
                {
                    english1.SayHello();
                }
            }

            #endregion

            Console.WriteLine(new string('*', 10));

            #region 虛方法 將父方法標記virtual，子方法標記override

            foreach (var item in persons)
            {
                item.SayHello();
            }

            #endregion
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

        public virtual void SayHello()
        {
            System.Console.WriteLine($"Hello, Person");
        }
    }

    public class Chinese : Person
    {
        public Chinese(string name) : base(name)
        {
        }

        public override void SayHello()
        {
            System.Console.WriteLine($"Hello, Chinese");
        }
    }

    public class Korean : Person
    {
        public Korean(string name) : base(name)
        {
        }

        public override void SayHello()
        {
            System.Console.WriteLine($"Hello, Korean");
        }
    }

    public class English : Person
    {
        public English(string name) : base(name)
        {
        }

        public override void SayHello()
        {
            //沒有override，會呼叫父類別的方法
            base.SayHello();
        }
    }
}