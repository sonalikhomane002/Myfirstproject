using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Basic
{
    class Addition
    {
        static void Main(string[] args)
        {
            int num1 = 15;
            int num2 = 5;
            int sum, substraction, division, multi;

            sum=num1 + num2;
            Console.WriteLine(sum);

            substraction = num1 - num2;
            Console.WriteLine(substraction);

            division = num1 / num2;
            Console.WriteLine(division);

            multi = num1 * num2;
            Console.WriteLine(multi);
        }
    }
}
