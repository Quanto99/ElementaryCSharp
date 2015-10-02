using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionNamespace
{
    public static class Recursion
    {
        private static int currentLevel = 0;
        public static void infiniteRecursion()
        {
            // When The maximum number of stack frames supported by Visual Studio has been exceeded,
            // the program is terminated, and no exception is thrown.
            try
            {
                Console.WriteLine(++currentLevel);
                infiniteRecursion();
            }
            catch (StackOverflowException e)
            {
                Console.Write("ERROR: Stack Overflow\n" + e.Message);
            }
            catch (Exception e)
            {
                Console.Write("ERROR: Generic Exception\n" + e.Message);
            }
        }
        public static void makeRecursiveCall(int x)
        {
            if (x == 0) return;

            Console.WriteLine(++currentLevel);

            // When The maximum number of stack frames supported by Visual Studio has been exceeded,
            // the program is terminated, and no exception is thrown.
            try
            {
                makeRecursiveCall(--x);
            }
            catch (StackOverflowException e)
            {
                Console.Write("ERROR: Stack Overflow\n" + e.Message);
            }
            catch (Exception e)
            {
                Console.Write("ERROR: Generic Exception\n" + e.Message);
            }
        }
    }
}
