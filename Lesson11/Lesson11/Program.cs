using System;

namespace Lesson11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var school = CreatSchool();
            PrintSchoolInfo(school);
            Console.WriteLine(CreatSchool());
        }

        static School CreatSchool()
        {
            School school = new School();
            return school;
        }

        static void PrintSchoolInfo(School school)
        {
            Console.Write("School name > ");
            school.NameSchool = Console.ReadLine();

            Console.Write("School number > ");
            school.NUmberSchool = int.Parse(Console.ReadLine());

            Console.Write("School address > ");
            school.AdressSchool = Console.ReadLine();

            Console.Write("Student capacity > ");
            school.Capacity = int.Parse(Console.ReadLine());

            Console.Write("Current student count > ");
            school.CurrentStudentCount = int.Parse(Console.ReadLine());

        }
    }
}
