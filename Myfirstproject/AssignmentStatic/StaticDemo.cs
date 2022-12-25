using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.AssignmentStatic
{
    class StaticDemo
    {
        static int x = 0;

         StaticDemo()
         {
            x++;
            Console.WriteLine(x);
         }
        static void Main(string[] args)
        {
            StaticDemo d = new StaticDemo();
            StaticDemo d1 = new StaticDemo();
        }

    }
    class StaticDemo2
    {
        int x = 10;
        static int y = 20;

        public void show()
        {
            Console.WriteLine(x+" "+y);
        }
        public static void Display()
        {
            StaticDemo2 obj = new StaticDemo2();
            Console.WriteLine(obj.x+" "+y);
        }
        static void Main(string[] args)
        {
            StaticDemo2 d = new StaticDemo2();
            d.show();
            StaticDemo2.Display();
        }
    }
    class staticDemoTask
    {
        public static int calculation(int x, int y)
        {
            int val = x * y;
            return val;
        }
        static void Main(string[] args)
        {
            // Console.WriteLine(calculation(12, 12));
            int res = staticDemoTask.calculation(5, 2);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
    class Car
    {
        static string model;
        static int totalcarsold;

       




    }

}
