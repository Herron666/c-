using System;

namespace завдання_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ведіть значення a =");

            double a = double.Parse(Console.ReadLine());

            Console.Write("Ведіть значення b =");

            double b = double.Parse(Console.ReadLine());

            Console.Write("Ведіть значення c =");

            double c = double.Parse(Console.ReadLine());

            if (3 <= a && a <= 9)

            {
                Console.WriteLine("а належить z");
            }
            else if (b <= a && a <= c)
            {
                Console.WriteLine("а належить z");
            }
            else
            {
                Console.WriteLine("а не належить z");
            }
        }
    }
}
