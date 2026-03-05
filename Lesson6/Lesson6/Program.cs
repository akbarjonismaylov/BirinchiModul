using System.ComponentModel;
using System.Globalization;
using System.Numerics;

namespace Lesson6
{
    internal class Program
    {
        /* //1

         static void Main(string[] args)
         {
             Console.WriteLine(Add("34", "33"));
         }

         static void Add(float a, float b)
         {
             var result = a + b;
         }
         static void Add(float a, float b, float c)
         {
             var result = a + b + c;
         }
         static void Add(string a, string b)
         {
             var result = a + b;
         }*/

        /*//2
        static void Main(string[] args)
        {
            repeat(1, 2);
        }

        static void repeat(int a, int b)
        {
            for (int i = 0; i < b; i++)
            {
                Console.WriteLine(a);
            }
        }*/

        /* //3
         static void Main(string[] args)
         {
             calculate(1, 2, 3);
         }

         static void calculate(int a, int b)
         {
             var sum = a + b;
             Console.WriteLine(sum);
         }

         static void calculate(int a, int b, int c)
         {
             var sum = a * b * c;
             Console.WriteLine(sum);
         }
     }*/

        /* //4
         static void Main(string[] args)
         {
             Console.WriteLine(getAmountDigit("jnvevev2cafv"));
         }

         static int getAmountDigit(int a)
         {
             int count = 0;
             for (int i = 1; a > 0; i++)
             {
                 a /= 10;
                 count = i;
             }
             return count;
         }

         static int getAmountDigit(string a)
         {
            return a.Count(char.IsDigit);

         }*/

        /*//5
        static void Main(string[] args)
        {
            Console.WriteLine(findMax(1, 2, 3, 4));
        }

        static int findMax(int a, int b, int c)
        {
            int max = Math.Max(c, Math.Max(a, b));
            return max;
        }

        static int findMax(int a, int b, int c, int z)
        {
            int max =Math.Max(z, Math.Max(c, Math.Max(a, b)));
            return max;
        }*/

        /*//6
        static void Main(string[] args)
        {
            Console.WriteLine(multiplication(3));
            Console.WriteLine(multiplication(2, 4));
            Console.WriteLine(multiplication(2, 4, 5));
        }

        static int multiplication(int a)
        {
            int sum = 1;
            for (int i = 1; i <= a; i++)
            {
                sum *= i;
            }
            return sum;
        }

        static int multiplication(int a, int b)
        {
            int sum = 1;
            for (int i = a; i <= b; i++)
            {
                sum *= i;
            }
            return a;
        }

        static int multiplication(int a, int b, int c)
        {
            return a * b * c;
        }*/

        /*//7
        static void Main(string[] args)
        {
            Digit(1234355);
        }

        static void Digit(int a)
        {
            int count = 0;
            for (int i = 1; a > 0; i++)
            {
                a /= 10;
                count = i;
            }
            Console.WriteLine(count);
        }*/

        //9

        static void Main(string[] args)
        {
            Console.Write("Enter a number > ");
            var num = int.Parse(Console.ReadLine());
            Cube(num);
        }

        static void Cube(int a)
        {
            double c = 0;
            for (int i = 1; i <= a; i++)
            {
                
                c = c + Math.Pow(i, 3);
            }
            Console.WriteLine(c);
        }
    }
}
