using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Basic
{
    class Perimeter
    {
        static void Main(string[]args)
        {
            float Perimeter;
            Console.WriteLine("enter the length of rectangle");
            float length = float.Parse(Console.ReadLine());

            Console.WriteLine("enter the witdth of rectangle");
            float width = float.Parse(Console.ReadLine());
            Perimeter = 2*(length + width);

            Console.WriteLine(Perimeter);

        }
    }
}
