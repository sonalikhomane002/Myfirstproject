using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ConditionalDemo
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int fact = 1,i;
            Console.WriteLine("enter the value of num");
            int num = int.Parse(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("factorial of num"  +fact);

        }
        

    }
}
