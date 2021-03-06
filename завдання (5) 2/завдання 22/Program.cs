using System;

namespace завдання_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            
            int n = int.Parse(Console.ReadLine());
            
            double[]masiv = new double [n];

            for (int i = 0; i < n; i++)
            {
                masiv[i] = double.Parse(Console.ReadLine());
            }
            double a = -99999999;

            for (int i = 0; i < n; i++)
            {
                if (masiv [i] < 0 )
                {
                    if (masiv[i] > a) 
                    {
                        a = masiv[i];

                    }
                }
            }

            Console.WriteLine(a);
            
        }
    }
}
