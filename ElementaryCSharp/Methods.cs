using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementaryCSharp
{
    class Methods
    {
        public static void SwapR(ref string first, ref string second)
        {
            string temp = first;
            first = second;
            second = temp;
        }

        public static void SwapV(string first, string second)
        {
            string temp = first;
            first = second;
            second = temp;
        }

        public static double Squares(double x, out double squareRoot)
        {
            double squared;

            squareRoot = System.Math.Sqrt(x);

            squared = x * x;

            return squared;
        }
    }
}
