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
            // Todo:  Add argument processing

            int n = 1;


            // Break these out into separate items

            switch (n)
            {
                case 0:

                    Console.Write("\nStatic member variables\n");

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

                    Console.Write("Class X1:    i={0}\n", X1.i);    // direct access to static member variable

                    Console.Write("\nStatic Methods\n");

                    X1.increment_static();
                    X1.display_static("Class X1");

                    break;

                case 1:

                    // Property exercises

                    P1 p = new P1();

                    p.a = 41;
                    //p.b = 42; - would get compiler error since b is read-only
                    p.c = 999999;

                    p.Print("a");
                    p.Print("b");
                    p.Print("c");



                    break;

                default:

                    throw new ArgumentException("Invalid command argument.");

            }

        }   
    }

    public class X1
    {
        public static int i;    // initializes to 0

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

        public static void display_static(string instance)
        {
            Console.Write("Instance {0}:    i={1}\n", instance, i);
        }

        public static void increment_static()
        {
            i++;
        }

    }

    public class P1
    {
        public int a { get; set; }

        public int b
        {
            get
            {
                return _b;
            }
        }
        private int _b = 42;

        public int c
        {
            get
            {
                return _c;
            }

            set
            {
                if (value < 1000000)
                {
                    _c = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("c", value, "Must be < 1000000");
                }
            }
        }
        private int _c;

        public void Print(string property)
        {
            int x = 0;

            switch (property)
            {
                case "a":
                    x = a;
                    break;

                case "b":
                    x = b;
                    break;

                case "c":
                    x = c;
                    break;

                default:

                    throw new ArgumentException();
            }

            Console.Write("Property {0} = {1}\n", property, x);
        }
    }
}
