using System;

namespace ExecuteSqlCommandDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            using (var db = new MyDbContext())
            {
                var sql = @"create table dbo.ProductUser
                (
                    id       int not null
                constraint id
                primary key,
                    account  varchar(10),
                password varchar(10)
                    )
                ";
                var result = db.Database.ExecuteSqlCommand(sql);
                Console.WriteLine(result);
            }
        }
    }
}