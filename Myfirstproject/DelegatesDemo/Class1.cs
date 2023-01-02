using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.DelegatesDemo
{
    public delegate T area<T>(T param);
    public delegate T square<T>(T param);
    class GenericDemo
    {
        public static float Area(float  r)
        {
            return 3.14f * r * r;
        }
        public static int Square(int no)
        {
            return no * no;
        }
        static void Main(string[] args)
        {
            area<float> Area = GenericDemo.Area;
            Console.WriteLine(Area(5));
            square<int> s = GenericDemo.Square;
            Console.WriteLine(Square(5));
        }
    }
    
}
