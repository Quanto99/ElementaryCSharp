using System;

namespace StaticNamespace
{
    public class S1
    {
        public static int i;    // initializes to 0

        public S1()
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

}
