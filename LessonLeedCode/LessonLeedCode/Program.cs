namespace LessonLeedCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Name > ");
            string Name = Console.ReadLine();

            Console.Write("Age > ");
            int Age = int.Parse(Console.ReadLine());

            Console.Write("Enter your email > ");
            string Email = Console.ReadLine();

            Console.Write("Enter your ID > ");
            string Id = Console.ReadLine();

            Console.Write("Enter your phone number > ");
            string Phone = Console.ReadLine();

            User user = new User();

            user.name = Name;
            Console.WriteLine($"Name > {user.name}");

            user.age = Age;
            Console.WriteLine($"Age > {user.age}");

            user.email = Email;
            Console.WriteLine($"Email > {user.email}");

            user.id = Id;
            Console.WriteLine($"ID > {user.id}");

            user.phone = Phone;
            Console.WriteLine($"Phone number > {user.id}");

        }
    }
}


