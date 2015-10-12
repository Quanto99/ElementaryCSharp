using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementaryCSharp
{
    class Methods
    {
        // arguments passed by reference
        public static void SwapR(ref string first, ref string second)
        {
            string temp = first;
            first = second;
            second = temp;
        }

        // arguments passed by value
        public static void SwapV(string first, string second)
        {
            string temp = first;
            first = second;
            second = temp;
        }

        // example of output parameter and return value
        public static double Squares(double x, out double squareRoot)
        {
            double squared;

            squareRoot = System.Math.Sqrt(x);   // output parameter assignment

            squared = x * x;    // return value assignment

            return squared;
        }
    }
}
