using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Basic
{
    class Expression
    {
        static void Main(string[]args)
        {
            double x,Y;
            x = (25.5 * 3.5 - 3.5 * 3.5) / (40.5 - 4.5);
            Y = 4.0 * (1 - (1.0 / 3) + (1.0 / 5) - (1.0 / 7) + (1.0 / 9) - (1.0 / 11));
            Console.WriteLine(x);
            Console.WriteLine(Y);
        }
    }
}
