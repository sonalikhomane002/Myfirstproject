using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ConditionalDemo
{
    class Divisibleby3or9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the value num1");
            int num1 = int.Parse(Console.ReadLine());

            if(num1 % 3 == 0 && num1 % 9 == 0)
            {
                Console.WriteLine("num is Divisible by 3 and 9");
            }

        }
    }
}
