using System;

namespace Завдання_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");

            double n = double.Parse(Console.ReadLine());

            int i = 3;

            double f = 0;

            double ff = 9;

            double fff = 9;

            double ffff = 0;

            if (n >= 3)
            {
                while (i <= n)
                {
                    ffff = fff + ff + f;

                    f = ff;

                    ff = fff;

                    fff = ffff;

                    i++;
                }
                double d = ffff;

                Console.WriteLine("Результат = {0}", d);
            }
            else if (0 <n || n <= 2)
            {
                Console.WriteLine("Результат = 9");
            }
            else if (n == 0)
            {
                Console.WriteLine("Результат = 0");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
