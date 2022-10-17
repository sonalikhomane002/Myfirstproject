using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Assignment
{
    class Fibboq4
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int c = 0;
            Console.WriteLine(a);
            for (int i = 1; i <= 10; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }
        }
    }
}
