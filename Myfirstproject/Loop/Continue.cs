using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loop
{
    class Continue
    {
        static void Main(string[] args)
        {
            
            for (int i = 1; i <= 10; i++)
            {
                if (i == 3)
                {
                    continue;

                }
                Console.WriteLine(i);

            }
            Console.WriteLine();
        }
    }
}
