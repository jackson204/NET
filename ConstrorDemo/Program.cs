using System;
using System.Security.Permissions;

namespace ConstrorDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var student = new Student("BBB");
            Console.WriteLine($"{student.Name} , {student.Age}");

            //寫一個Ticket class 有一個距離 Distance 屬性(只能讀且不能為負數)
            //有一個價格Price 屬性，價格屬性只能讀
            //根據 distance 計算價格 Price(1元/公里)

            var ticket = new Ticket(90);
            ticket.ShowTicket();
        }
    }
}