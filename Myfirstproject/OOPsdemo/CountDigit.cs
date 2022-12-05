using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPsdemo
{
    class CountDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the value of num");
            int n = int.Parse(Console.ReadLine());

            int count = 0;
            do
            {
                n = n / 10;
                count++;

            } while (n != 0);
            Console.WriteLine(count);
        }
    }
}
