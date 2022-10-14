using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loop
{
    class Oddnum
    {
        static void Main(string[] args)
        {
            //Print odd number from 1to 20;
            int sum = 0;
            for (int i = 1; i <= 5; i = i + 2)
            {
                Console.WriteLine(i);
                sum = sum + i;
            }
            Console.WriteLine(sum);
        }
    }
}
