using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Assignment
{
    class Q7Pattern
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int k = 1; k < i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 6 - i; j >= 1; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }


        }
    }
}
