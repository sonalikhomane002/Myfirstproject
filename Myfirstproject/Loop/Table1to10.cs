using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loop
{
    class Table1to10
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 1; i <= 10; i++)
            {
                for (j = 1; j <= 10; j++)
                {
                    Console.Write(i * j + "  ");
                }
                Console.WriteLine();

            }
            Console.ReadKey();

        }

    }
}
