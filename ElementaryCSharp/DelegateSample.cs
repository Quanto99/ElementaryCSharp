using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementaryCSharp
{
    public delegate bool ComparisonHandler(int first, int second);

    class DelegateSample
    {
        public static void BubbleSort(int[] items, ComparisonHandler comparisonMethod)
        {
            int i, j, temp;

            if (items == null) return;

            if (comparisonMethod == null)
            {
                throw new ArgumentNullException("comparisonMethod");
            }

            for (i = items.Length - 1; i >= 0; i--)
            {
                for (j = 1; j <= i; j++)
                {
                    if (comparisonMethod(items[j - 1], items[j]))
                    {
                        temp = items[j - 1];
                        items[j - 1] = items[j];
                        items[j] = temp;
                    }
                }
            }
        }

        public static bool GreaterThan(int first, int second)
        {
            return first > second;
        }

        public static bool LessThan(int first, int second)
        {
            return first < second;
        }
    }
}
