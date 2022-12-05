using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPsdemo
{
    class PrimeNoinbetween
    {
        static void Main(string[] args)
        {
           
            for (int no = 400; no >= 300; no--)
            {

                int cnt = 2, prime = 1;

                while (cnt <= no / 2)
                {

                    if (no % cnt == 0)
                    {
                        prime = 0;
                        break;

                    }
                    cnt++;
                }
                if (prime == 1)
                {
                    Console.WriteLine(no+" ");
                }
            }
        }
    }
}
