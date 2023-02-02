using System;

namespace EqualDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //想單純地判斷二個字串裡的文字是否相符, 用 Equals() 是比較建議的寫法
            string s1 = "test";
            string s2 = "test";
            string s3 = "test1".Substring(0, 4);
            object s4 = s3;

            Console.WriteLine($"{object.ReferenceEquals(s1, s2)} {s1 == s2} {s1.Equals(s2)}");
            Console.WriteLine($"{object.ReferenceEquals(s1, s3)} {s1 == s3} {s1.Equals(s3)}");
            Console.WriteLine($"{object.ReferenceEquals(s1, s4)} {s1 == s4} {s1.Equals(s4)}");
        }
    }
}