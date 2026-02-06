namespace Lesson5_array_vs_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*//1
            Console.Write("List lengthini kiriting > ");
            var n = int.Parse(Console.ReadLine());

            List<int> ints = new List<int>();

            for (int i = 0; i < n; i++)
            {
                Console.Write($"List elementlarini kiriting > ");
                var num = int.Parse(Console.ReadLine());
                ints.Add(num);
            }

            Console.WriteLine();

            for (int i = 0; i < ints.Count; i++)
            {
                if (ints[i] > 99 && ints[i] <= 999)
                {
                    Console.WriteLine($"List elementlari 3 xonali sonlar {ints[i]}");
                }
            }*/


            /*//2

            Console.Write("enter list elements > ");
            int n = int.Parse(Console.ReadLine());

            List<int> ints = new List<int>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("List elementlarini kiriting > ");
                int num = int.Parse(Console.ReadLine());
                ints.Add(num);
            }

            Console.WriteLine();

            for (int i = 0; i < ints.Count; i++)
            {
                if (ints[i] % 2 == 0)
                {
                    Console.WriteLine($"List juft elementlari > {ints[i]}");
                }
            }*/


            /*//3

            Console.Write("List lengthini kiriting > ");
            int n = int.Parse(Console.ReadLine());

            List<int> ints = new List<int>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("List elementlarini kiriting > ");
                var num = int.Parse(Console.ReadLine());
                ints.Add(num);
            }

            Console.WriteLine();

            for (int i = 0; i < ints.Count; i++)
            {
                if (ints[i] % 2 == 1)
                {
                    Console.WriteLine($"List toq elementlari > {ints[i]}");
                }
            }*/


            /*//4

            Console.Write("List uzunligini kiriting > ");
            var n = int.Parse(Console.ReadLine());
            List<int> ints = new List<int>();

            for (var i = 0; i < n; i++)
            {
                Console.Write("List elementlarini kiriting > ");
                var num = int.Parse(Console.ReadLine());
                ints.Add(num);
            }

            Console.WriteLine();

            for (var i = 0; i < ints.Count; i++)
            {
                if (ints[i] % 3 == 0 && ints[i] % 7 == 0)
                {
                    Console.WriteLine($"Bu element 3 va 7 ga karrali sonlar > {ints[i]}");
                }
            }*/


            /*//5

            Console.Write("List uzunligini kiriting > ");
            int n = int.Parse(Console.ReadLine());
            List<int> ints = new List<int>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("Ikki xonali List elementlarini kiriting > ");
                int num = int.Parse(Console.ReadLine());
                ints.Add(num);
            }
            Console.WriteLine();
            for (int i = 0; i < ints.Count; i++)
            {
                if (ints[i] > 9 && ints[i] < 99 && ints[i] % 2 == 1)
                {
                    Console.WriteLine($"List elementining ikki xonali toq elementi > {ints[i]}");
                }
            }*/


            /* //6 

             Console.Write("List uzuligini kiriting > ");
             int n = int.Parse(Console.ReadLine());
             List<int> ints = new List<int>();

             for (int i = 0; i < n; i++)
             {
                 Console.Write("List elementlarini kiriting > ");
                 var num = int.Parse(Console.ReadLine());
                 ints.Add(num);
             }

             var index = ints[0];
             ints[0] = ints[n - 1];
             ints[n - 1] = index;

             Console.WriteLine();

             foreach (int i in ints)
             {
                 Console.WriteLine(i);
             }*/


            /*//7

            Console.Write("List uzunligini kiriting > ");
            var n = int.Parse(Console.ReadLine());
            List<int> ints = new List<int> { };

            for (var i = 0; i < n; i++)
                ints.Add(int.Parse(Console.ReadLine()));

            var sum = (ints[0] + ints[1] + ints[2]);

            Console.WriteLine();

            Console.WriteLine(sum);*/


            /*//8

            Console.Write("List uzunligini kiriting > ");
            var n = int.Parse(Console.ReadLine());

            List<int> ints = new List<int>();

            for (int i = 0; i < n; i++)
                ints.Add(int.Parse(Console.ReadLine()));

            var sum = (ints[^3] + ints[^2] + ints[^1]);
            
            Console.WriteLine();

            Console.WriteLine(sum);*/




        }
    }
}

