using System;

namespace PropertiesNamespace
{
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