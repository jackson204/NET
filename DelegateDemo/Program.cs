using System;

namespace DelegateDemo
{
    //為何需要委託 ?  使用委託將方法作為參數傳給另一個方法
    //能被委託調用的方法須滿足以下條件:
    // 1.方法的返回值必須和委託定義的一致
    // 2.方法的參數類型 個數和順序必須和委託定義的一致
    // 3.大部分時候被委託執行的方法必須為 static
    internal class Program
    {
        private delegate void DelShowWorld();

        public static void Main(string[] args)
        {
            #region 無參數

            // 無參數的();

            #endregion

            #region 有參數的

            // 有參數的();
            
            #endregion
            
            // 匿名
            // 1.先定義一個委託
            // 2.定義匿名方法
            #region 無參數匿名
           
            // 無參數匿名();

            #endregion

            #region 有參數的匿名

            // 有參數的匿名();

            #endregion 
            
            #region Lambda無參數匿名

           // Lambda無參數匿名();

            #endregion

            #region Lambda有參數的匿名

           // Lambda有參數的匿名();

            #endregion
        }

        private static void Lambda有參數的匿名()
        {
            DelShowName message2 = name => $"Hi  {name}";
            Console.WriteLine(new string('$', 10));

            //真正執行 
            var result = message2("Lambda有參數的匿名 Tom");
            Console.WriteLine(result);
        }

        private static void Lambda無參數匿名()
        {
            DelShowWorld showWorld = () => Console.WriteLine("Lambda無參數匿名");

            //真正執行
            showWorld();
        }

        private static void 有參數的匿名()
        {
            DelShowName message2 = delegate(string name)
            {
                return $"Hi {name}";
            };
            Console.WriteLine(new string('$', 10));

            //真正執行 
            var result = message2("匿名 Tom");
            Console.WriteLine(result);
        }

        private static void 無參數匿名()
        {
            DelShowWorld showWorld = delegate
            {
                Console.WriteLine(" 無參數匿名");
            };

            //真正執行
            showWorld();
        }

        private static void 無參數的()
        {
            #region 寫法一

            //建立委託物件，委託的方法是誰
            DelShowWorld showWorld = new DelShowWorld(ShowHelloWorld);

            //真正執行 相當於執行ShowHelloWorld()
            showWorld.Invoke();

            #endregion

            Console.WriteLine(new string('*', 10));

            #region 寫法二

            DelShowWorld showWorld2 = ShowHelloWorld; // DelShowWorld showWorld = new DelShowWorld(ShowHelloWorld);
            showWorld2();                             // showWorld.Invoke();

            #endregion

            Console.WriteLine(new string('*', 10));

            //宣告
            Action action = () =>
            {
                Console.WriteLine("action Hello World");
            };
            Console.WriteLine(new string('*', 10));

            //執行
            action.Invoke();
        }

        private static void 有參數的()
        {
            #region 寫法一

            //建立委託物件，要委託的方法是誰
            DelShowName delShowName = new DelShowName(ShowName);

            //真正執行 相當於執行ShowName()
            var message = delShowName.Invoke("Tom2");
            Console.WriteLine(message);

            #endregion

            Console.WriteLine(new string('*', 10));

            #region 寫法二

            //建立委託物件，要委託的方法是誰
            DelShowName delShowName2 = ShowName; // 相當於DelShowName delShowName = new DelShowName(ShowName);

            //真正執行 相當於執行ShowName()
            var message2 = delShowName("Tom3"); // 相當於 delShowName.Invoke("Tom2");
            Console.WriteLine(message2);

            #endregion

            Console.WriteLine(new string('*', 10));
        }

        public delegate string DelShowName(string name);

        private static void ShowHelloWorld()
        {
            Console.WriteLine("Hello World");
        }

        private static string ShowName(string name)
        {
            return $"Hi {name}";
        }
    }
}