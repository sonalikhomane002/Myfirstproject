using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Constructor
{
    class Circle
    {
        public float area;


        public Circle(float r)
        {
            area = 3.14f * r * r;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the radius");
            float r = float.Parse(Console.ReadLine());
            Circle obj = new Circle(r);
            Console.WriteLine("Area of circle is"+obj.area);

        }
    }
}
