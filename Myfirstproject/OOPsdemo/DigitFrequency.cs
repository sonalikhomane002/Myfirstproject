using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPsdemo
{
    class DigitFrequency
    {
        static void Main(string[] args)
        {
            int i, count, digit, temp;
            Console.WriteLine("enter the number");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Digit\tFrequency");
            for (i = 0; i <= 9; i++)
            {
                count = 0;
                temp = number;
                while (temp > 0)
                {
                    digit = temp % 10;
                    if (digit == i)
                    {
                        count++;
                    }
                    temp = temp / 10;
                }
                if (count > 0)
                {
                    Console.WriteLine(i + "\t" + count);
                }
            }

        }
    }

}