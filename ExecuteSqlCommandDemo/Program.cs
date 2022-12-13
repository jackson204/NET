using System;
using System.Data.Entity;
using System.Linq;

namespace ExecuteSqlCommandDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            using (var db = new MyDbContext())
            {
                db.Database.Log = s => Console.WriteLine(s);
                //Ceate Table
                // var sql = @"create table dbo.ProductUser
                // (
                //     id       int not null
                // constraint id
                // primary key,
                //     account  varchar(10),
                // password varchar(10)
                //     )
                // ";
                
                //查詢
                var sql =$@"SELECT TOP (1000) [id]
                    ,[account]
                ,[password]
                FROM [MyDB2].[dbo].[ProductUser]";
                
                
                var result = db.Database.SqlQuery<ProductUser>(sql);
                var productUser = result.FirstOrDefault(r => r.id ==1);
            
                Console.WriteLine(productUser.account);
            }
        }
    }

    internal class ProductUser
    {
        public int id { get; set; }

        public string account { get; set; }

        public string password { get; set; }
    }
}