using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loop
{
    class RectangleHollow
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
               

                for (int j = 1; j <= 4; j++)
                {
                    if (i == 1 || j == 1 || j == 4 || i == 4)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }

                Console.WriteLine();
            }
        }
    }
}
