using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Assignment
{
    class Q14
    {
        static void Main(string[] args)
        {
            int a=0, b=1, c = 0;
            Console.WriteLine(b);
            for(int i = 1; i <= 20; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }
        }
    }
}
