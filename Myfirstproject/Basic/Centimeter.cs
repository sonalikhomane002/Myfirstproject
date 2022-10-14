using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Basic
{
    class Centimeter
    {
        static void Main(string[]args)
        {
            double meter, kilometer;
            Console.WriteLine("enter length in centimeter");
            float Cm = float.Parse(Console.ReadLine());
            meter = Cm / 100.0;
            kilometer =Cm / 100000.0;
            Console.WriteLine(meter);
            Console.WriteLine(kilometer);

        }
    }
}
