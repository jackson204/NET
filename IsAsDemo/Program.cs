using System;

namespace IsAsDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //子類可以賦值給父類
            Person student = new Student();
            student.PersonSayHello();

            Console.WriteLine(new string('-', 20));

            //父類可以強轉為子類

            #region is  如果能成通轉換 返回true ;

            if (student is Teacher)
            {
                Teacher s = (Teacher) student;
                s.PersonSayHello();
            }
            else
            {
                Console.WriteLine("else");
            }

            #endregion 

            #region As 如果能成功轉換就成功 失敗就null; 

            Teacher student1 = student as Teacher;

            Student student2 = student as Student;
            student2.StudentSayHello();

            #endregion
        }
    }

    internal class Person
    {
        public void PersonSayHello()
        {
            Console.WriteLine("Person Hello");
        }
    }

    internal class Student : Person
    {
        public void StudentSayHello()
        {
            Console.WriteLine("Student Hello");
        }
    }

    internal class Teacher : Person
    {
        public void TeacherSayHello()
        {
            Console.WriteLine("Teacher Hello");
        }
    }
}