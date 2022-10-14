using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ConditionalDemo
{
    class PositiveNegative
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter the num");
            int num = int.Parse(Console.ReadLine());
            if(num>0)
            {
                Console.WriteLine("num is positive");
            }
            else if(num<0)
            {
                Console.WriteLine("num is negative");
            }
            else 
            {
                Console.WriteLine("num is zero");
            }
        }
    }
}
