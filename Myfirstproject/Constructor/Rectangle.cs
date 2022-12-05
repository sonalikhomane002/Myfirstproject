using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Constructor
{
    class Rectangle
    {
        public float length;
        public float width;
        public float perimeter;


        public void acceptData(float length,float width)
        {
            this.length = length;
            this.width = width;
        }
        public void CalculatePerimeter()
        {
            perimeter = 2 * (length + width);
        }
        public void Display()
        {
            Console.WriteLine("Perimeter of Rectangle is"+perimeter);
        }
        static void Main(string[] args)
        {
            Rectangle obj = new Rectangle();
            obj.acceptData(12, 6);
            obj.CalculatePerimeter();
            obj.Display();
        }
    }
}
