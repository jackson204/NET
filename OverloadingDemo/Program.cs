using System;

namespace OverloadingDemo
{
    internal class Program
    {
        //方法名稱相同，參數不同，與回傳值無關
        //參數不同 分兩種情形
        //1.參數個數相同，那麼參數的型別就不能相同
        //2.參數類型相同，那麼參數的個數就不能相同
        public static void Main(string[] args)
        {
            M(1,2);
            M("Hi","Tom");
            M(1,2,3);
            
        }
        private static void M(int i, int j)
        {
            
        }
        private static void M(string name, string i)
        {
            
        }
        private static void M(int i, int j , int z)
        {
            
        }

        
    }
}