using System;
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
            using (var db = new MyDbContext())
            {
                db.Database.Log = Console.WriteLine;

                #region 新增

                // var user = new User()
                // {
                //     Email = "AA",
                //     Pwd = "123456",
                //     LoginTime = DateTime.Now,
                //     Orders = new List<Order>()
                //     {
                //         new Order()
                //         {
                //             Address = "Address",
                //             Message = "Message",
                //             Phone = "89841310",
                //             Status = "Status",
                //         },
                //         new Order()
                //         {
                //             Address = "2Address2",
                //             Message = "2Message2",
                //             Phone = "298413102",
                //             Status = "2Status2",
                //         },
                //     }
                //
                //     // user.Orders
                // };
                // db.Users.Add(user); //debug 模式 db.ChangeTracker.Entries()
                // db.SaveChanges();

                #endregion

                #region virtual 延遲加載

                var user = db.Users.FirstOrDefault(r=>r.Id==1);
                
                // SELECT TOP (1)
                //     [Extent1].[Id] AS [Id],
                // [Extent1].[Email] AS [Email],
                // [Extent1].[Pwd] AS [Pwd],
                // [Extent1].[LoginTime] AS [LoginTime]
                // FROM [dbo].[User] AS [Extent1]
                // WHERE 1 = [Extent1].[Id]

                Console.WriteLine(new string('*', 20));

                var userOrders = user.Orders;
                // SELECT
                //     [Extent1].[Id] AS [Id],
                // [Extent1].[Phone] AS [Phone],
                // [Extent1].[Address] AS [Address],
                // [Extent1].[Message] AS [Message],
                // [Extent1].[Status] AS [Status],
                // [Extent1].[OrderDateTime] AS [OrderDateTime],
                // [Extent1].[Total] AS [Total],
                // [Extent1].[UserId] AS [UserId]
                // FROM [dbo].[Order] AS [Extent1]
                // WHERE [Extent1].[UserId] = @EntityKeyValue1

                Console.WriteLine(new string('*', 20));

                #endregion

                #region 立即加載

                var result = db.Users.Include(r => r.Orders).FirstOrDefault(r=>r.Id==1);
                Console.WriteLine(result);

                #endregion
            }
        }
    }
}