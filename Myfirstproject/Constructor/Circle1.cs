using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Constructor
{
    //staic keyword example
    class Circle1
    {
        static double PI = 3.14;
        double r;
        static int c;

        public Circle1()
        {
            c++;

        }
        public Circle1(double pI,double r)
        {
            PI = pI;
            this.r = r;
            c++;
        }
        public static int ReturnObjectCount()
        {
            return c;
        }
        static void Main(string[] args)
        {
            Circle1 c1 = new Circle1();
            Console.WriteLine("object created are"+Circle1.ReturnObjectCount());
            Circle1 c2 = new Circle1(3.14, 3.4);
        }

    }
  
}
