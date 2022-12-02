#nullable enable
using System;

namespace FluentAPIDemo
{
    public class Person
    {
        public int? Age { get; set; }

        public DateTime CreateDateTime { get; set; }   
        public DateTime? EndDateTime { get; set; }

        public long Id { get; set; }

        public string? JobOccupation { get; set; }

        public string Name { get; set; }
        public int Salary { get; set; }
    }
}