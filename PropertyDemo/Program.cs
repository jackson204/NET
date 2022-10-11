using System.Runtime.InteropServices;

namespace PropertyDemo
{
    internal class Program
    {
        //屬性的作用就是保護字段，對字段的賦值與取值進行限定
        //屬性的本質就是兩個方法，get(),set()
        public static void Main(string[] args)
        {
            //需用debug模式觀看，程式碼如何運行
            var person = new Person();
            person.Age = -12;
            person.CHCSS();
          
        }
    }
}