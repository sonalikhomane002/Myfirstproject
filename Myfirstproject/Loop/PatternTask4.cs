using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loop
{
    class PatternTask4
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }

                Console.WriteLine();
            }

           


        }
    }
}
