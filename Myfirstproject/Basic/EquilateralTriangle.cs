using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Basic
{
    class EquilateralTriangle
    {
        static void Main(string[]args)
        {
            
            Console.WriteLine("enter side of equilateral triangle");
            double Side = double.Parse(Console.ReadLine());
            double area = (1.73 * Side * Side) / 4;
            Console.WriteLine("Area of Equilateral Triangle is :" + area);
        }
    }
}
