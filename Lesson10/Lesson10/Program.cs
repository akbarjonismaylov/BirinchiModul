namespace Lesson10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student student = new student();
            student.Name = "Akbarjon";
            student.Surname = "Ismaylov";
            student.Age = 21;
            student.Group = "515_22";
            student.University = "TUIT";

            Console.WriteLine($"Name: {student.Name}");
            Console.WriteLine($"Surname: {student.Surname}");
            Console.WriteLine($"Age: {student.Age}");
            Console.WriteLine($"Group: {student.Group}");
            Console.WriteLine($"University: {student.University}");

            Console.WriteLine();

            student student2 = new student();
            student2.Name = "Shaxzod";
            student2.Surname = "Ismaylov";
            student2.Age = 21;
            student2.Group = "515_22";
            student2.University = "TUIT";

            Console.WriteLine($"Name: {student2.Name}");
            Console.WriteLine($"Surname: {student2.Surname}");
            Console.WriteLine($"Age: {student2.Age}");
            Console.WriteLine($"Group: {student2.Group}");
            Console.WriteLine($"University: {student2.University}");


        }
    }
}


