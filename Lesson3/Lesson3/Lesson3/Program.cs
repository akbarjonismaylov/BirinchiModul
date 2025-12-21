namespace Lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Uch xonali son kiriting: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 100; i < 999; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
