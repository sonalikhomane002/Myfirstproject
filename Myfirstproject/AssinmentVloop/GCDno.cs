using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.AssinmentVloop
{
    class GCDno
    {
        static void Main(string[] args)
        {
            int n1 = 50, n2 = 60;
            while (n1 != n2)
            {
                if (n1 > n2)
                    n1 = n1 - n2;
                else
                    n2 = n2 - n1;
            }
            Console.WriteLine("GCD of n1 and n2 is: " + n2);
        }
    }
}
