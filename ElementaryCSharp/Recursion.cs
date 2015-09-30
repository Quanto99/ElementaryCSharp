using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionNamespace
{
    public static class Recursion
    {
        public static void infiniteRecursion()
        {
            // When The maximum number of stack frames supported by Visual Studio has been exceeded (5000 stack frames)
            // the program is terminated, and no exception is thrown.
            try
            {
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
            catch
            {
                Console.Write("ERROR: Other Exception\n");
            }
        }
    }
}
