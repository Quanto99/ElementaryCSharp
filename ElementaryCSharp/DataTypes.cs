﻿using System;
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
                    _float *= _float;
                    Console.WriteLine("float:   " + _float);
                    _double *= _double;
                    Console.WriteLine("double:  " + _double);
                    _decimal *= _decimal;
                    Console.WriteLine("decimal: " + _decimal);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: " + e.Message);
            }
        }
            
    }
}
