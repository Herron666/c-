using System;

namespace Завдання__6__4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть N = ");

            int N = int.Parse(Console.ReadLine());

            double x0 = 0;

            double x1 = 9;

            double x2 = 9;

            double x4 = 0;

            for (int i = 3; i < N + 3; i++)
            {
                x4 = x2 + x1 + x0;

                x0 = x1;

                x1 = x2;

                x2 = x4;

            }


            Console.WriteLine(x4);

        }
    }
}
