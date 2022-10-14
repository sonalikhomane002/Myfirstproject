using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ConditionalDemo
{
    class Digitsum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the num");
            int num = int.Parse(Console.ReadLine());

            if (num > 99 && num < 1000)
            {
                Console.WriteLine("3 digit number", +num);

                int temp1 = num % 10;
                num = num / 100;
                int sum = temp1 + num;

                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("not 3 digit num" + num);
            }
        }
    }
}
