using System;

namespace лабака_1_с
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіь значення а=");

            int a = int.Parse(Console.ReadLine());

            Console.ReadLine();

            double s = Math.Pow(a, 2);

            Console.WriteLine(s);

            int p = a + a + a + a;

            Console.WriteLine("площа квадрата: {0};периметр квадрата: {1}", s, p);

        }
    }
}
