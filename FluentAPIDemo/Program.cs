using System;

namespace FluentAPIDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            using var db = new MyDbContext();
            //查看sql 語法
            db.Database.Log =(s) => Console.WriteLine(s);

            // var person = new Person
            // {
            //     Name = "Name1",
            //     Age = 18,
            //     Salary = 100,
            //     JobOccupation = "Job",
            //     CreateDateTime = DateTime.Now
            // };
            // db.Persons.Add(person);
            //
            //
            // var person2 = new Person
            // {
            //    // Name = "Name1",
            //     Age = 18,
            //     Salary = 100,
            //     JobOccupation = "Job",
            //     CreateDateTime = DateTime.Now
            // };
            //
            // db.Persons.Add(person2);
            //
            // var person3 = new Person
            // {
            //    // Name = "Name1",
            //     //Age = 18,
            //     Salary = 100,
            //     JobOccupation = "Job",
            //     CreateDateTime = DateTime.Now
            // };
            //
            // db.Persons.Add(person3);
            //
            // #region Salary 不允續null int 
            // var person4 = new Person
            // {
            //     // Name = "Name1",
            //     //Age = 18,
            //     // Salary = 100,
            //     JobOccupation = "Job",
            //     CreateDateTime = DateTime.Now
            // };
            //
            // db.Persons.Add(person4);
            //
            //
            // #endregion
            //
            // var person5 = new Person
            // {
            //    // Name = "Name1",
            //     // Age = 18,
            //     // Salary = 100,
            //      JobOccupation = "Job",
            //     CreateDateTime = DateTime.Now
            // };
            //
            // var trim = person5.JobOccupation.Trim();//看之後還會不會用到
            // db.Persons.Add(person5);
            //
            //
            // db.SaveChanges();
            // var person6 = new Person
            // {
            //     Name = "Name1",
            //     Age = 18,
            //     Salary = 100,
            //     JobOccupation = "Job",
            //     CreateDateTime = DateTime.Now
            // };
            // db.Persons.Add(person6);
            // db.SaveChanges();

            var product = new Product()
            {
                ProductName = "test"
            };
            //Add()添加紀錄時，只是將數據提交道內存，沒有提交到數據庫
            db.Product.Add(product);
            //提交道數據庫
            db.SaveChanges();
        }
    }
}