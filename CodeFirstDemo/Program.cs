﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using CodeFirstDemo.Model;

namespace CodeFirstDemo
{
    internal class Program
    {
        //1 user 對應 多個 order
        public static void Main(string[] args)
        {
            using (var _db = new MyDbContext())
            {
                var user = new User()
                {
                    Email = "AA",
                    Pwd = "123456",
                    LoginTime = DateTime.Now,
                    Orders = new List<Order>()
                    {
                        new Order()
                        {
                            Address = "Address",
                            Message = "Message",
                            Phone = "89841310",
                            Status = "Status",
                        },
                        new Order()
                        {
                            Address = "2Address2",
                            Message = "2Message2",
                            Phone = "298413102",
                            Status = "2Status2",
                        },
                    }
                
                    // user.Orders
                };
                 _db.Users.Add(user);
                _db.SaveChanges();

            }
        }
    }
}