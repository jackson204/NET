namespace InheritanceDemo
{
    internal class Student : Person
    {
        public int Id { get; set; }

        public string Study()
        {
            return "Study";
        }

        public Student(string name, int age, char gender,int id)
            : base(name, age, gender)
        {
            Id = id;
        }
    }

  
}