using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loop
{
    class Automorphic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the value of num");
            int num = int.Parse(Console.ReadLine());

            int square = 1;
            int count = 0;
            int temp = num;

            while (num > 0)
            {
                int digit = num % 10;
                count++;
                num = num / 10;
            }
            Console.WriteLine(count);

            num = temp;
            int Power = 1;
            int Base = 10;
            square = num * num;

            for (int i = 1; i <= count; i++)
            {
                Power = Power * Base;
            }
            Console.WriteLine(square);
            int last = square % Power;
            if (num == last)

            {
                Console.WriteLine("Automorphic:");
            }
            else
            {
                Console.WriteLine(" Not a Automorphic:");
            }

        }
    }
}
