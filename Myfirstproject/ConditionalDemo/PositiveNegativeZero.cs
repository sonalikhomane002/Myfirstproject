using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ConditionalDemo
{
    class PositiveNegativeZero
    {
        static void Main(string[] args)
        {
            string result;
            Console.WriteLine("enter the value of num");
            int num = int.Parse(Console.ReadLine());

            result= (num >= 0) ? (num == 0 ? "zero" : "positive") : "negative";
            Console.WriteLine(result);
        }
    }
}
