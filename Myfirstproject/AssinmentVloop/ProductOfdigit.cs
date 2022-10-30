using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.AssinmentVloop
{
    class ProductOfdigit
    {
        static void Main(string[] args)
        {
            int product = 1;
            Console.WriteLine("enter the value of num");
            int num = int.Parse(Console.ReadLine());

            while(num>0)
            {
                product = product * (num % 10);
                num = num / 10;
            }
            Console.WriteLine(product);
        }
    }
}
