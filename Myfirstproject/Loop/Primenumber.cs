using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loop
{
    class Primenumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());

            bool isPrime = true;
            int i = 2;
            while( i < num)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                }
                i++;
            }
            if (isPrime == true)
            {
                Console.WriteLine("prime");

            }
            else
            {
                Console.WriteLine("not Prime");
            }
        }
    }
}
