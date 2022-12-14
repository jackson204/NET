using System;
using System.Globalization;

namespace CodeFirstDemo
{
    public class Order
    {
        public int Id { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string Message { get; set; }

        public string Status { get; set; }

        public DateTime? OrderDateTime { get; set; }

        public double Total { get; set; }

        //virtual 延遲加載
        public virtual User User { get; set; }

        public int UserId { get; set; }
    }
}