namespace ExtensionMethodDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var student = new Student();
            student.Show();
            student.Run();

            student.ShowMyself("Tom", 12);

            var globe = new Globe();
            var globe1 = globe.V(4);
            var d = globe.S(1.2);
        }
    }
}