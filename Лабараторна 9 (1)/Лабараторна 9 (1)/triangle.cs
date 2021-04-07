using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабараторна_9__1_
{
    class triangle
    {
        public double A { set { A = value; } get { return A; } }

        public double B { set { B = value; } get { return B; } }

        public triangle() { }

        public triangle(double A, double B)
        {
            this.A = A;

            this.B = B;
        }

        public triangle(triangle previoustriangle)
        {
            A = previoustriangle.A;
        }

        public double S()
        {
            return 1 / 2 * (A * B);
        }

        public double P()
        {
            double C = Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2));

            return A + B + C;
        }
        public string comparisontriangle(triangle othertriangle)
        {
            if (P() == othertriangle.P())
            {
                return "Трикутники рівні";
            }
            else
            {
                return "Трикутники не рівні";
            }
        }

        public string TRG_intput_output()
        {
            return $"A {A}, B {B}";
        }


        public static triangle operator +(triangle triangle, triangle randTriangle)
        {
            triangle n1 = new triangle(triangle);
            triangle n2 = new triangle(randTriangle);
            return new triangle(triangle.A + randTriangle.A, triangle.B + randTriangle.B);
        }
        public static triangle operator -(triangle triangle, triangle randTriangle)
        {
            triangle m1 = new triangle(triangle);
            triangle m2 = new triangle(randTriangle);
            return new triangle(triangle.A - randTriangle.A, triangle.B - randTriangle.B);
        }
        public static triangle operator *(triangle triangle, double k)
        {
            return new triangle(triangle.A * k, triangle.B * k);
        }
    }
}
