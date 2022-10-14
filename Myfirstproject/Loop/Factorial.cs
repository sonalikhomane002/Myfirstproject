using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loop
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int i = 1;
            int fact = 1;
            Console.WriteLine("enter the value of num");
            int num = int.Parse(Console.ReadLine());

            while(i<=num)
            {
                fact = fact * i;
                i++;
            }
            Console.WriteLine(fact);
        }
    }
}
