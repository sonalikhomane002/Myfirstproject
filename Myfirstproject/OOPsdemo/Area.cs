using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPsdemo
{
    class Area
    {
        public void AreaofRectangle(int length,int breadth)
        {
            int area = length * breadth;
            Console.WriteLine("Area of Rectangle is="+area);
        }
        public void AreaofCircle(double a)
        {
            double area = (3.14)* a * a;
            Console.WriteLine("Area of Circle is="+area);
        }
        public void Areaofsquare(int a)
        {
            int area = a * a;
            Console.WriteLine("Area of square is="+area);
        }
        static void Main(string[] args)
        {
            Area area = new Area();
            area.AreaofRectangle(5, 5);
            area.Areaofsquare(4);
            area.AreaofCircle(2.5);
        }
    }
}
