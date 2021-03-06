using System;

namespace завдання_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введіть значення x1 =");

            double x1 = double.Parse(Console.ReadLine());

            Console.WriteLine("введіть значення y1 =");

            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("введіть значення x2 =");

            double x2 = double.Parse(Console.ReadLine());

            Console.WriteLine("введіть значення y2 =");

            double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine("введіть значення x3 =");

            double x3 = double.Parse(Console.ReadLine());

            Console.WriteLine("введіть значення y3 =");

            double y3 = double.Parse(Console.ReadLine());

            double AB = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            double AC = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));

            double BC = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));

            if (AB == AC || AC == BC || BC == AB)
            {
                Console.WriteLine("Буде рівнобедреним");
            }
            else
            {
                Console.WriteLine("не буде рівнобедреним");
            }

        }
    }
}
