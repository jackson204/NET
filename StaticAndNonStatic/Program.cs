using System.Security.Principal;

namespace StaticAndNonStatic
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            var person = new Person();
            person.M1();
            
            //類.靜態方法
            Person.M2();
            Student.M3();
        }
    }
}