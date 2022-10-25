using System;
using System.Security.Permissions;

namespace InheritanceDemo
{
    internal class Program
    {
        //子類繼承父類的屬性與方法，但是子類沒有繼承父類的私有字段
        //子類沒有繼承父類的ctor 但是子類會默認調用父類的無參數的ctor，因為要創建父類的物件，讓子類可以使用父類的成員
        //https://dotblogs.com.tw/chichiBlog/2017/08/20/Inheritance
        //https://www.delftstack.com/zh-tw/howto/csharp/csharp-call-base-constructor/
        public static void Main(string[] args)
        {
            //但是子類會默認調用父類的無參數的ctor
            AirPlane airPlane = new AirPlane();
            airPlane.type = "Jstar";
            airPlane.name = "kiki";
            airPlane.speed = 300;
            airPlane.Info();
            
            //子類沒有繼承父類的ctor 但是子類會默認調用父類的無參數的ctor，因為要創建父類的物件，讓子類可以使用父類的成員 
            Teacher teacher = new Teacher("A",12,'d',1600);
            teacher.Teach();
            Student student = new Student("A",12,'d',24);
            student.Study();
            Driver driver = new Driver("A",13,'d',DateTime.Now);
            driver.Drive();

            //子類方法 與 父類方法相同 則呼叫子類的方法 
            student.SayHello();
        }
    }
}