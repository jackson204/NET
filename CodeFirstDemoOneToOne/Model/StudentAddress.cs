namespace CodeFirstDemoOneToOne.Model
{
    public class StudentAddress
    {
        public int StudentAddressId { get; set; }
        public string Address { get; set; }
        public Student Student { get; set; }
    }
}