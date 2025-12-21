namespace Lesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
        }

        static int findMax(int a, int b, int c)
        {
            return Math.Max(a, Math.Max(b, c));
        }

        static int findMax(int a, int b, int c, int d)
        {
            return Math.Max(findMax(a, b, c), d);
        }

        static int findMax(int a, int b, int c, int d, int e)
        {
            return Math.Max(findMax(a, b, c, d), e);
        }


    }
}
