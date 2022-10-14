using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ConditionalDemo
{
    class Maxnum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the value of num");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the value of num");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the value of num");
            int num3 = int.Parse(Console.ReadLine());
            int max = 0;
            if(num1>num2&&num1>num3)
            {
                max = num1;
            }
            else if(num2>num1 && num2>num3)
            {
                max = num2;
            }
            else
            {
                max = num3;
            }
            Console.WriteLine(" Max num=" +max);
        }

    }
}
