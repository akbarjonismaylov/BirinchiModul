using System.Threading.Channels;

namespace Lesson8
{
    internal class Program
    {
        /*static void Test(ref int x)
        {
            x *= 2;
        }
        static void Main(string[] args)
        {
            int a = 5;

            Test(ref a);
            Console.WriteLine(a);
        }*/

        /*static void Test(out int x)
        {
            int.TryParse(Console.ReadLine(), out x);
        }
        static void Main(string[] args)
        {
            int a;
            Test(out a);
            Console.WriteLine(a);
        }*/

        /*static void Test(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            Test(ref a, ref b);
            Console.WriteLine($"a: {a}, b: {b}");
        }*/

        /*static void Test(out int x, out int result)
        {
            int.TryParse(Console.ReadLine(), out x);

            result = x * x;
        }
        static void Main(string[] args)
        {
            int a;
            int b;
            Test(out a, out b);
            Console.WriteLine(b);
        }*/

        /*static void Test(ref int x)
        {
            if (x % 2 == 0)
            {
                x = 0;
            }
        }
        static void Main(string[] args)
        {
            int a = 1;
            Test(ref a);
            Console.WriteLine(a);
        }*/

        /*static void Test(ref int x)
        {
            if (x < 0)
            {
                x *= -1;
            }
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            Test(ref a);
            Console.WriteLine(a);
        }*/

        static List<string> Names = new List<string>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Create ");
                Console.WriteLine("2. Delete ");
                Console.WriteLine("3. Update ");
                Console.WriteLine("4. Read ");

                Console.Write("Tanlang > ");

                int.TryParse(Console.ReadLine(), out int a);

                if (a == 1)
                {
                    Console.Write("Ismni kiriting > ");
                    string name = Console.ReadLine();
                    CreateName(name);
                }

                else if (a == 2)
                {
                    Console.Write("Ismni o'chirish uchun ismni kiriting > ");
                    string name = Console.ReadLine();
                    DeleteName(name);
                }

                else if (a == 3)
                {
                    Console.Write("Eski ismni kiriting > ");
                    string name1 = Console.ReadLine();
                    Console.Write("Yangi ismni kiriting > ");
                    string name2 = Console.ReadLine();
                    UpdateName(name1, name2);
                }

                else if (a == 4)
                {
                    ReadNames();
                }

                Console.ReadKey();
                Console.Clear();

                static void CreateName(string name)
                {
                    Names.Add(name);
                }

                static void DeleteName(string name)
                {
                    Names.Remove(name);
                }

                static void UpdateName(string oldName, string newName)
                {
                    int index = Names.IndexOf(oldName);
                    if (index != -1)
                    {
                        Names[index] = newName;
                    }
                }

                static void ReadNames()
                {
                    foreach (var name in Names)
                    {
                        Console.WriteLine(name);
                    }
                }
            }
        }
    }
}
