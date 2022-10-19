using System;

namespace InheritanceDemo
{
    internal class Driver : Person
    {
        public DateTime DriveTime { get; set; }

        public string Drive()
        {
            return "Drive";
        }

        public Driver(string name, int age, char gender , DateTime dateTime)
            : base(name, age, gender)
        {
            this.DriveTime = dateTime;
        }
    }
}