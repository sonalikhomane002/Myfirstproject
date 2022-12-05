using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPsdemo
{
    class BreakUse
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                if (i == 3)
                {
                    break;

                }
                Console.WriteLine(i);

            }
            Console.WriteLine(); 
        }
    }
}
