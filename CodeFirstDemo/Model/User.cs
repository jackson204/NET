using System;
using System.Collections.Generic;

namespace CodeFirstDemo
{
    public sealed class User
    {
        public User()
        {
            Orders = new HashSet<Order>();
        }
        public int Id { get; set; }

        public string Email { get; set; }

        public string Pwd { get; set; }

        public DateTime? LoginTime { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}