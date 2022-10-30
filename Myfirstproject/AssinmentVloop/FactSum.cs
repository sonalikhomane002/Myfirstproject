using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.AssinmentVloop
{
    class FactSum
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                int fact = 1;
                for (int j = 1; j <= i; j++)
                {
                    fact = fact * j;
                }

                sum = sum + fact;
            }

            Console.WriteLine(sum);
        }
    }
}
