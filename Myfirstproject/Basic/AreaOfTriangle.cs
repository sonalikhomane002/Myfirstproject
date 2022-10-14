using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Basic
{
    class AreaOfTriangle
    {
        static void Main(string[]args)
        {

            Console.Write("enter the base:");
            double Base = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter the Height:");
            double Height = Convert.ToDouble(Console.ReadLine());

            double Area = (Base * Height) / 2;
            Console.Write("area of a triangle = " + Area);

        }
    }
}
