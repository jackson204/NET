using System;

namespace EnumDemo
{
    internal class Program
    {
        public enum Gender
        {
            男,
            女
        }

        // 默認情況下，每個枚舉值的基數類型是 int
        private enum QqState
        {
            OnLine,
            OffLine = 3,
            Leave,
            Busy
        }

        public static void Main(string[] args)
        {
            #region enum 強轉成 int

            // 變量類型  變量名 = 值
            QqState qqState = QqState.Busy;

            //enum 默認是可以跟int 互相轉換 
            int n = (int) qqState;
            Console.WriteLine((int) QqState.OnLine); // 從0開始
            Console.WriteLine((int) QqState.OffLine);
            Console.WriteLine((int) QqState.Leave);
            Console.WriteLine((int) QqState.Busy);

            #endregion

            #region int 轉成 enum

            int a = 3;
            Console.WriteLine((QqState) a);

            a = 8; //不再enum 的 則  吐原值
            Console.WriteLine((QqState) a);

            #endregion

            #region enum 轉 string

            QqState state = QqState.Busy;
            var format = state.ToString();
            Console.WriteLine(format);

            #endregion

            #region string 轉 enum

            string name = "Leave";
            // QqState o = (QqState)name;(無法強制轉換) 強轉的前提是兩個類型需要兼容
            //string轉成int int.Parse()
            Type enumType = typeof(QqState);
            //parse()目的是為了讓他幫助我們將一個string轉換成對應的枚舉類型
            QqState o = (QqState) Enum.Parse(enumType, name);
            Console.WriteLine(o);
            
            name = "9"; //不再enum 的 則  吐原值
            var type = typeof(QqState);
            o = (QqState) Enum.Parse(type, name);
            Console.WriteLine(o);

            // 如果無法轉換則抱錯
            name = "ASDS";
            o = (QqState) Enum.Parse(typeof(QqState), name);
            Console.WriteLine(o);

            #endregion
        }
    }
}