using System;

namespace InheritanceDemo
{
    internal class Teacher : Person
    {
        public int Salary { get; set; }

        public string Teach()
        {
            return "Teach";
        }

        //將子類的建構函式中的引數傳遞給基類的建構函式
        public Teacher(string name, int age, char gender, int salary)
            : base(name, age, gender)
        {
            Salary = salary;
        }
    }
}