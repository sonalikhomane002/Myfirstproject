using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.AssinmentVloop
{
    class LCMno
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the n1");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the n2");
            int n2 = int.Parse(Console.ReadLine());

            int lcm = (n1 > n2) ? n1 : n2;

            while (true)
            {
                if (lcm % n1 == 0 && lcm % n2 == 0)
                {
                    Console.WriteLine("The LCM of " + n1 + " and " + n2 + " is " + lcm);
                    break;
                }
                ++lcm;
            }
        }

    }
}
