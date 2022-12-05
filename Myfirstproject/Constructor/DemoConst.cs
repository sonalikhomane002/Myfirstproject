using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Constructor
{
    class DemoConst
    {
        const int no= 22;

        public void show()
        {
            Console.WriteLine("no is "+no);
        }
        static void Main(string[] args)
        {
            const double PI = 3.14;
            double r = 3.2, area;
            area = PI * r * r;
            Console.WriteLine("area is"+area);
        }
    }
}
