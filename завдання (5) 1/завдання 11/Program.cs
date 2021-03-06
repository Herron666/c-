using System;

namespace завдання_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 12;
             
            Console.Write("Введіть значення a = ");

            double a = double.Parse(Console.ReadLine());

            double f = 0;

            int i = 1;

            while (n >= i)
            {
                double ff = f - Math.Cos(Math.Pow(a, i) / 12);

                f = ff;

                i++;
            }

            Console.WriteLine("Результат = {0}" , f);
            
        }
    }
}
