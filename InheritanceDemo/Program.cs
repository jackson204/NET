using System;
using System.Security.Permissions;

namespace InheritanceDemo
{
    internal class Program
    {
        //子類繼承父類的屬性與方法，但是子類沒有繼承父類的私有字段
        //子類沒有繼承父類的ctor 但是子類會默認調用父類的無參數的ctor，因為要創建父類的物件，讓子類可以使用父類的成員
        public static void Main(string[] args)
        {
            var teacher = new Teacher("A",12,'d',1600);
            teacher.Teach();
            var student = new Student("A",12,'d',24);
            student.Study();
            var driver = new Driver("A",12,'d',DateTime.Now);
            driver.Drive();
        }
    }
}