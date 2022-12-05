using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Constructor
{
    class Class1
    {
        //call by reference
        public static void CallByRef(double r, ref double a, ref double p)
        {
            a = 3.14 * r * r;
            p = 2 * 3.14 * r;
        }
        static void Main(string[] args)
        {
            double r = 2.5, area = 0.0, perimeter = 0.0;
            CallByRef(r, ref area, ref perimeter);
            Console.WriteLine("Area is " + area);
            Console.WriteLine("Perimeter is " + perimeter);
        }
    }
}
