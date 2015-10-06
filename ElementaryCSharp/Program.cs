using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StaticNamespace;
using PropertiesNamespace;
using RecursionNamespace;
using DataTypesNamespace;

// Essential C# 4.0
//
//  Data types
//      Floating Point Type (float,double)
//      Decimal Type
//      Literals*
//      Hex literals*
//      Round-trip formatting*
//      Verbatim string literal*
//      String methods: static and instance*
//      String properties*
//      String immutability*
//      System.Text.Stringbuilder data type*
//      String as reference type
//  Operators and Countrol Flow
//  Methods and Parameters
//  Classes
//  Inheritance
//  Interfaces
//  Value Types
//  Well-Formed Types
//  Exception Handling
//  Generics
//  Delegates and Lambda Expressions
//  Events
//  Collection Interfaces with Standard Query Operators
//  LINQ with Query Expressions
//  Building Custom Collections
//  Reflection, Attributes, and Dynamic Programming
//  Multithreading
//  Synchronization and More Multithreading Patterns
//  Platform Interoperability and Unsafe Code
//  The Common Language Infrastructure


namespace ElementaryCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string sVal;

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
                    p.Print("a");

                    //p.b = 42; - would get compiler error since b is read-only
                    p.Print("b");

                    Console.Write("What is the value to be added to 999999?");
                    sVal = Console.ReadLine();
                    // convert input string to int
                    int x = System.Convert.ToInt32(sVal);

                    try
                    {
                        p.c = 999999 + x;
                    }
                    catch (ArgumentOutOfRangeException e)
                    {
                        Console.Write("ERROR: " + e.Message + "\n");
                        break;
                    }

                    p.Print("c");



                    break;

                case "recursion":

                    Console.Write("Input number of levels of recursion: ");
                    sVal = Console.ReadLine();

                    if (sVal == "infinite")
                    {
                        // When The maximum number of stack frames supported by Visual Studio has been exceeded (5000 stack frames)
                        // the program is terminated, and no exception is thrown; i.e. an exception is not caught here or in the inner
                        // exception handler in the Recursion class.

                        try
                        {
                            Recursion.infiniteRecursion();
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
                    else
                    {
                        // Note that the BCL-name for this data type is System.Int16 with range -32,768 to 32,767.
                        short recursionLevels = 0;

                        try
                        {
                            recursionLevels = System.Convert.ToInt16(sVal);
                        }
                        catch (Exception e)
                        {
                            Console.Write("ERROR: " + e.Message);
                            break;
                        }

                        try
                        {
                            Recursion.makeRecursiveCall(recursionLevels);
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

                    break;

                case "datatypes":

                    DataTypes.Run();

                    DataTypes d = new DataTypes();
                    d.printStrings();

                    break;

                default:

                    Syntax();
                    break;

            }

        }

        public static void Syntax()
        {
            Console.WriteLine("\nSyntax:    ECS <command>");
            Console.WriteLine("Commands:\n");
            Console.WriteLine("           static");
            Console.WriteLine("           properties");
            Console.WriteLine("           recursion");
            Console.WriteLine("           datatypes");
        }
    }
}
