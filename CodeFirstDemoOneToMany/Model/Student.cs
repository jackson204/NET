namespace CodeFirstDemoOneToMany.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Grade CurrentGrade { get; set; }

        public int CurrentGradeId { get; set; }
    }
}