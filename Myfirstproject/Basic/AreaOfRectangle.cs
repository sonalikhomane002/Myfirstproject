using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Basic
{
    class AreaOfRectangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the length of a rectangle: ");
            int Length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the breadth of a rectangle: ");
            int Breadth = Convert.ToInt32(Console.ReadLine());
            int Area = Length * Breadth;
            Console.WriteLine(Area);
        }
    }
}
