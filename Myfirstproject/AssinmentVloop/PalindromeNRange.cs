using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.AssinmentVloop
{
    class PalindromeNRange
    {
        static void Main(string[] args)
        {
            for (int n = 100; n <= 500; n++)
            {

                int rem; int reverse = 0;
                int temp = n;
                while (temp > 0)
                {
                    rem = temp % 10;
                    reverse = reverse * 10 + rem;
                    temp = temp / 10;
                }
                if (n == reverse)
                    Console.WriteLine(n);


            }




            
        }
    }
}
