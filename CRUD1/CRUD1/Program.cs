namespace CRUD1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First Name > ");
            string FirstName = Console.ReadLine();

            Console.Write("Last Name > ");
            string LastName = Console.ReadLine();

            Console.Write("Position > ");
            string Position = Console.ReadLine();

            Console.WriteLine("Age > ");
            int Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Salary ($) > ");
            int Salary = int.Parse(Console.ReadLine());

            Employee user = new Employee();

            user.FirstName
        }
    }
}
