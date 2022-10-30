using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loop
{
    class Primesingleno
    {
        static void Main(string[] args)
        {
            int n = 1;
            Boolean isPrime;
            while (n <= 100)
            {
                isPrime = true;
                int i = 2;
                while (i <= n / 2)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    i++;
                }
                if (isPrime)
                    Console.WriteLine(n);
                n++;
            }
            Console.ReadKey();
        }
    }
    
}
