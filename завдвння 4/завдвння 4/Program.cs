using System;

namespace завдвння_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть значення X = ");

            double X = double.Parse(Console.ReadLine());

            Console.Write("Введіть значення Y = ");

            double Y = double.Parse(Console.ReadLine());

            Console.Write("Введіть значення E = ");

            double E = double.Parse(Console.ReadLine());

            if (Y < X) 
            {
                double Z = Y * Math.Pow(E, X);

                Console.WriteLine("Z = {0}", Z);
            }
            else if (Y == X)
            {
                double Z = Y * X;

                Console.WriteLine("Z = {0}", Z);
            }
            else if (Y > X)
            {
                double Z = X * Math.Pow(E, Y);

                Console.WriteLine("Z = {0}", Z);
            }
            else
            {
                Console.WriteLine("Порожня множина");
            }

        }
    }
}
