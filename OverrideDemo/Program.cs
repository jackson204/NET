using System;

namespace OverrideDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Person p = new Person("Person");
            Chinese chinese = new Chinese("成龍");
            English english = new English("Amy");
            Japanese japanese = new Japanese("櫻木花道");

            Person[] person = {p,chinese, english, japanese};

            #region 父類呼叫

            // for(int i = 0; i < person.Length; i++)
            // {
            //     person[i].SayHello();
            // }

            #endregion

            #region 子類呼叫

            // for(int i = 0; i < person.Length; i++)
            // {
            //     if (person[i] is Chinese chinese1)
            //     {
            //         chinese1.SayHello();
            //     }
            //     else if (person[i] is English english1)
            //     {
            //         english1.SayHello();
            //     }
            //     else if (person[i] is Japanese japanese1)
            //     {
            //         japanese1.SayHello();
            //     }
            //     else
            //     {
            //         person[i].SayHello();
            //     }
            // }

            #endregion

            #region 讓一個對象能表現出多種的類型 將父類的方法 virtual 

            for(int i = 0; i < person.Length; i++)
            {
                //Person 的 SayHello  只不過這方法被子類重寫
                person[i].SayHello();
                
            }

            #endregion
            
            
        }
    }

    internal class Person
    {
        private string _name;

        public Person(string name)
        {
            Name = name;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public virtual void SayHello()
        {
            Console.WriteLine($"我是Person");
        }
    }

    internal class Chinese : Person
    {
        public Chinese(string name)
            : base(name)
        {
        }

        public override void SayHello()
        {
            Console.WriteLine($"我是{Name}");
        }
    }

    internal class English : Person
    {
        public English(string name)
            : base(name)
        {
        }

        public override void SayHello()
        {
            Console.WriteLine($"My name is {Name}");
        }
    }

    internal class Japanese : Person
    {
        public Japanese(string name)
            : base(name)
        {
        }
        
        public override void SayHello()
        {
            Console.WriteLine($"Japanese is {Name}");
        }
    }
}