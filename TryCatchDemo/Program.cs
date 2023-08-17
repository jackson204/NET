using System;

namespace TryCatchDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // NewMethod();

            // NewMethod1();
            // NewMethod2();
            // NewMethod3();
            try
            {
                MyExtensionException3(17);
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e}");
            }
        }

        private static void MyExtensionException3(int age)
        {
            if (age < 18)
            {
                throw new MyException3("年齡不符合");
            }
        }

        private static void NewMethod3()
        {
            try
            {
                MyExtensionException(17);
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e}");
            }
        }

        private static void NewMethod2()
        {
            try
            {
                MyExtensionException(17);
            }
            catch (Exception e)
            {
                // 查看e.ToString()的內容 就知道為何需要呼叫base(message )
                Console.WriteLine($"{e.ToString()}");
            }
        }

        private static void MyExtensionException(int age)
        {
            if (age < 18)
            {
                throw new MyException("年齡不符合");
            }
        }
        private static void MyExtensionException2(int age)
        {
            if (age < 18)
            {
                throw new MyException2("年齡不符合");
            }
        }
        private static void NewMethod1()
        {
            try
            {
                Test(17);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private static void Test(int age)
        {
            if (age < 18)
            {
                throw new Exception("年齡不符合");
            }
        }

        private static void NewMethod()
        {
            Console.WriteLine("請輸入數字");
            var readLine = Console.ReadLine();
            var b = true;
            var input = 0;
            try
            {
                //語法上沒有錯誤，在運行中，某些原因出現了錯誤，不能運行
                input = Convert.ToInt32(readLine);
            }
            catch (FormatException e)
            {
                Console.WriteLine($"不能轉為數字 {e.Message}");
                b = false;
            }

            if (b)
            {
                Console.WriteLine($"數字 {input}");
            }
        }
    }

    /// <summary>
    /// 沒有繼承 也沒有override ToString()
    /// </summary>
    internal class MyException3 : Exception
    {
        public MyException3(string m)
        {
         
        }
    }

    /// <summary>
    /// use override ToString()
    /// </summary>
    internal class MyException2 : Exception
    {
        private readonly string _s;

        public MyException2(string s)
        {
            _s = s;
        }

        public override string ToString()
        {
            return _s;
        }
    }

    /// <summary>
    /// use base(message)
    /// </summary>
    internal class MyException : Exception
    {
        public MyException(string s) : base(s)
        {
        }
    }
}