using System;

namespace PropertyDemo
{
    internal class Person
    {
        //存取數據
        private int _age;

        public int Age
        {
            // 相當於
            //     public int Get_age()
            // {
            //     return this._age;
            // }
            get
            {
                return _age;
            } 
            //     相當於
            //     public void Set_age(int value)
            // {
            //     _age = value;
            // }
            //當給屬性賦值的時候
            set
            {
                if (value < 0 || value > 100)
                {
                    value = 0;
                }
                _age = value;
            }
        }

        public void CHCSS()
        {
            Console.WriteLine(Age);
        }
    }
}