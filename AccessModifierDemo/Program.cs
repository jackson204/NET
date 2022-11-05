using System;
using System.Security.AccessControl;

namespace AccessModifierDemo
{
    // public :公開的
    // private : 私有的，只能當前類的內部訪問
    // protected : 只能當前類的內部以及該類的子類別訪問
    // internal:只能當前的項目訪問，在同一個項目中，internal 和 public 的權限是一樣的
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }

    //能夠修飾class的訪問修飾的只有兩個: public internal
    internal class Person
    {
    }

    public class Student
    {
    }
}