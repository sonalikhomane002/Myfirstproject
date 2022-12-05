using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPsdemo
{
    class OddSum
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("enter the value of n");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i = i + 2)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
        }
    }
}
