using System;
using System.Collections.Generic;

namespace CodeFirstDemo
{
    public class User
    {
        public User()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }

        public string Email { get; set; }

        public string Pwd { get; set; }

        public DateTime? LoginTime { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}