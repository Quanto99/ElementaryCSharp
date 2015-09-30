using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StaticNamespace;
using PropertiesNamespace;

namespace ElementaryCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Syntax();
                return;
            }

            switch (args[0])
            {
                case "static":

                    Console.Write("\nStatic member variables\n");

                    S1 x1 = new S1();   // 1st instance
                    x1.display("x1");   // print static variable
                    x1.increment();
                    x1.display("x1");   // print static variable

                    S1 x2 = new S1();   // 2nd instance
                    x2.display("x2");

                    S1 x3 = new S1();   //3rd instance
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

                    Console.Write("Class S1:    i={0}\n", S1.i);    // direct access to static member variable

                    Console.Write("\nStatic Methods\n");

                    S1.increment_static();
                    S1.display_static("Class S1");

                    break;

                case "properties":

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

                    Syntax();
                    break;

            }

        }

        public static void Syntax()
        {
            Console.WriteLine("Syntax:  ECS <command>\n");
            Console.WriteLine("Commands:\n");
            Console.WriteLine("static\n");
            Console.WriteLine("properties\n");
        }
    }
}
