using System;
using System.Collections.Generic;
using System.Linq;

namespace RecordClassDemo
{
    internal class Program
    {
        //使用debug 觀察兩者的差異
        public static void Main(string[] args)
        {   
            //record 建立物件的時候  會多一些值
            var aa = new AA("",1);
            var bb = new AA("",1);
            var b = aa == bb;
            var myClas = new MyClas()
            {
                Type1 = "",
                Type = 1
            };
            var myClas2 = new MyClas()
            {
                Type1 = "",
                Type = 1
            };
            var c = myClas == myClas2;
            Console.WriteLine($"record {b} class {c}");

            //觀察植有沒有被過濾
            var list = new List<AA>(){aa,bb}.Distinct();
            Console.WriteLine(list);
        }
    }

    internal record AA(string Account, int Id)
    {
        public string Account { get; } = Account;

        public int Id { get; } = Id;
    }

    public class MyClas
    {
        public string Type1 { get; set; }
        public int Type { get; set; }
    }



   
}