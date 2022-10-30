using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.AssinmentVloop
{
    class Power
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the base value: ");
            int Base = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the exponent value: ");
            int exp = int.Parse(Console.ReadLine());
            long result = 1;
            Console.WriteLine(Base + " raised to the power " + exp + " is: ");
            while (exp != 0)
            {
                result *= Base;
                --exp;
            }
            Console.WriteLine(result);
        }
    }
}
