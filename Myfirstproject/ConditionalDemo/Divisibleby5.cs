using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ConditionalDemo
{
    class Divisibleby5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of num");
            int num = int.Parse(Console.ReadLine());
            if(num%5==0)
            {
                Console.WriteLine("number is divisible by 5");
            }
            else
            {
                Console.WriteLine("num is not divisible by 5");
            }

        }
    }
}
