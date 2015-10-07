using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataTypesNamespace
{
    class DataTypes
    {
        static float _float = 1000;
        static double _double = 1000;
        static decimal _decimal = 1000;

        string _s1 = null;
        string _s2 = null;

        // This won't compile...
        //public static double operator ^(
        //    double operand, double exponent)
        //{
        //    double result = operand;

        //    while (--exponent > 0)
        //    {
        //        result *= operand;
        //    }
            
        //    return result;
        //}

        public static void Run()
        {
            try
            {
                while (true)
                {
                    _float = (float)Math.Pow(_float, 2);
                    Console.WriteLine("float:   " + _float);

                    _double = Math.Pow(_double, 2);
                    Console.WriteLine("double:  " + _double);

                    _decimal = (decimal)Math.Pow((double)_decimal, 2);
                    //_decimal *= _decimal;
                    Console.WriteLine("decimal: " + _decimal);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: " + e.Message);
            }
        }

        public void printStrings()
        {
            _s1 = _s2;
            _s2 = "This is a string.";

            Console.WriteLine("_s1: " + _s1);
            Console.WriteLine("_s2: " + _s2);
        }

        public void printLiterals()
        {
            System.Console.WriteLine(42);
            System.Console.WriteLine(1.618034);
            System.Console.WriteLine(1.618033988749895);
            System.Console.WriteLine(1.618033988749895m);
            System.Console.WriteLine(6.023e23f);
            System.Console.WriteLine(1.23e-40f);
            System.Console.WriteLine(0x002a);
            System.Console.WriteLine("0x{0:X}", 42);
            System.Console.WriteLine(string.Format("{0:R}", 1.618033988749895));

            System.Console.Write(@"begin triangle

                /\
               /  \
              /    \
             /      \
            /________\
end");
        }
    }
    class Conversions
    {
        Int16 _n16 = Int16.MaxValue;
        Int32 _n32 = Int32.MaxValue;
        Int64 _n64 = Int64.MinValue;

        public void Test(int testNum)
        {
            switch (testNum)
            {
                case 16:

                    checked
                    {
                        _n32 = _n16;
                        System.Console.WriteLine(_n32);

                        _n32 = Int32.MaxValue;
                        _n16 = (Int16)_n32;
                        System.Console.WriteLine(_n16);
                    }
                    break;

                case 32:

                    checked
                    {
                        _n32 += 1;
                        System.Console.WriteLine(_n32);
                    }
                    break;

                case 64:

                    checked
                    {
                        string x = "9.11E-31";
                        float f = float.Parse(x);
                        System.Console.WriteLine(f);

                        _n64 -= 1;
                        System.Console.WriteLine(_n64);
                    }
                    break;

            }
        }
    }
}
