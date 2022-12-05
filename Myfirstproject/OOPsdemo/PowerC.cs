using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPsdemo
{
    class PowerC
    {
        static void Main(string[] args)
        {
            int b, i, power = 1;
            Console.WriteLine("enter the base");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the index");
            i = int.Parse(Console.ReadLine());

            for(int j=i;j>=1;j--)
            {
                power = power * b;
            }
            Console.WriteLine(b+"raised to" +i+ "is:=" +power);
        }
    }
}
