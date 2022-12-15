using System;
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
                // _db.Users.Add(user); //debug 模式 db.ChangeTracker.Entries()
                // _db.SaveChanges();

                #endregion

                #region virtual 延遲加載

                // var user = db.Users.FirstOrDefault(r=>r.Id==1);
                // Console.WriteLine(user.Email);

                // var userOrders = user.Orders;
                // foreach (Order order in userOrders)
                // {
                //     Console.WriteLine($"order Message {order.Message}");
                // } 

                #endregion

                #region including

                var reuslt = db.Users.Include(r => r.Orders).FirstOrDefault(r=>r.Id==1);
                Console.WriteLine(reuslt);

                #endregion
            }
        }
    }
}