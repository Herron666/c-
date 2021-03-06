using System;

namespace Завдвння__6__1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Розмірність простору: ");
            int n = int.Parse(Console.ReadLine());

            double[] x = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Введыть значення елементів = ");

                x[i] = double.Parse(Console.ReadLine());


            }
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0},", x[i]);

            }
            double a = -9999999;

            for (int i = 0; i < n; i++)
            {
                if (x[i] < 0)
                {
                    if (x[i] > a)
                    {
                        a = x[i];
                    }
                }
            }
            Console.Write("Максимальний елемент = {0}", a);
        }
    }
}
