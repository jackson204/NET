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

        public enum QQState
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
            QQState qqState = QQState.Busy;
            int n = (int) qqState;
            Console.WriteLine((int) QQState.OnLine); // 從0開始
            Console.WriteLine((int) QQState.OffLine);
            Console.WriteLine((int) QQState.Leave);
            Console.WriteLine((int) QQState.Busy);

            #endregion

            #region int 轉成 enum

            int a = 3;
            Console.WriteLine((QQState) a);

            a = 8; //不再enum 的 則  吐原值
            Console.WriteLine((QQState) a);

            #endregion

            #region enum 轉 string

            QQState state = QQState.Busy;
            var format = state.ToString();
            Console.WriteLine(format);

            #endregion

            #region string 轉 enum

            string name = "Leave";
            QQState o = (QQState) Enum.Parse(typeof(QQState), name);
            Console.WriteLine(o);

            name = "9"; //不再enum 的 則  吐原值
            o = (QQState) Enum.Parse(typeof(QQState), name);
            Console.WriteLine(o);
            
            // 如果無法轉換則抱錯
            name = "ASDS";
            o = (QQState) Enum.Parse(typeof(QQState), name);
            Console.WriteLine(o);

            #endregion
        }
    }
}