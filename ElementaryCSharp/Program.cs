using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementaryCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            X1 x1 = new X1();   // 1st instance
            x1.display("x1");   // print static variable
            x1.increment();
            x1.display("x1");   // print static variable

            X1 x2 = new X1();   // 2nd instance
            x2.display("x2");

            X1 x3 = new X1();   //3rd instance
            x3.display("x3");
            x3.increment();
            x3.display("x3");

            x1.increment();
            x1.display("x1");

            x2.increment();
            x2.display("x2");

            x3.increment();
            x3.display("x3");

            x1.increment();
            x1.display("x1");
            x2.display("x2");
            x3.display("x3");
        }   
    }

    public class X1
    {
        private static int i = 0;

        public X1()
        {
            i++;
        }

        public void display(string instance)
        {
            Console.Write("Instance {0}:    i={1}\n", instance, i);
        }

        public void increment()
        {
            i++;
        }
    }
}
