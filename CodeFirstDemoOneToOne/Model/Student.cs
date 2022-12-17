namespace CodeFirstDemoOneToOne.Model
{
    public class Student
    {
        public int StudentId { get; set; }

        public string Name { get; set; }

        public long Age { get; set; }

        public double Money { get; set; }

        public StudentAddress StudentAddress { get; set; }
    }
}