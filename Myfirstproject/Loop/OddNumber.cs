using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loop
{
    class OddNumber
    {
        static void Main(string[] args)
        {
            int num = 83273;
            int sum = 0;
            while (num > 0)
            {
                int rem = num % 10;
                if (rem % 2 != 0)
                {

                    sum = sum + rem;

                }
                num = num / 10;
            }
             Console.WriteLine(sum);
            
            
        }
    }
}
