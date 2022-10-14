using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ConditionalDemo
{
    class Sumofnum
    {
        static void Main(string[] args)
        {
            int i;
            int sum = 0;
            Console.WriteLine("enter the value of num");
            int num = int.Parse(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                sum = sum + i;

            }
            Console.WriteLine(sum);
        }
    }
}
