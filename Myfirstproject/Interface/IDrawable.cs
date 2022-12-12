using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Interface
{
    interface IDrawable
    {
        static int x = 90;

        public void draw();
    }
    interface IPrintable
    {
        void print();
    }
    class Shape : IDrawable, IPrintable
    {
        public void draw()
        {
            Console.WriteLine("Shape drawing......." + IDrawable.x);
        }
        public void print()
        {
            Console.WriteLine("Shape printing done.......");
        }
    }
    class InterfaceDemo
    {
        static void Main(string[] args)
        {
            IDrawable d = new Shape();
            d.draw();

            IPrintable p = new Shape();
            p.print();
        }
    }
    
}
