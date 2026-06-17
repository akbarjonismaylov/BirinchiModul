using System;
using System.Threading.Channels;

namespace Lesson11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var StudentPassword = "Ismaylov";

            Console.Write("Password > ");
            var inputPassword = Console.ReadLine();

            if (StudentPassword == inputPassword)
            {
                Console.WriteLine("CREATED!!!");
                Student student = CreateStudent();
                PrintStudent(student);
                Display(student);
            }
            else
            {
                Console.WriteLine("Wrong password!!!");
            }
        }
        static Student CreateStudent()
        {
            return new Student();
        }

        static void PrintStudent(Student student)
        {
            Console.Write($"Name: ");
            student.Name = Console.ReadLine();
            Console.Write($"Age: ");
            student.Age = int.Parse(Console.ReadLine());
            Console.Write($"School Name: ");
            student.SchoolName = Console.ReadLine();
            Console.Write($"Group: ");
            student.Group = Console.ReadLine();
            Console.Write($"Course: ");
            student.Course = Console.ReadLine();

            Console.WriteLine();
        }


        static void Display(Student student)
        {
            Console.WriteLine($"Name: {student.Name}");
            Console.WriteLine($"Age: {student.Age}");
            Console.WriteLine($"School Name: {student.SchoolName}");
            Console.WriteLine($"Group: {student.Group}");
            Console.WriteLine($"Course: {student.Course}");
        }
    }
}
