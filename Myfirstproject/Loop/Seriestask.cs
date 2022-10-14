using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loop
{
    class Seriestask
    {

        static void Main(string[] args)
        {
            int c = 3;
            bool Flag = true;

            Console.WriteLine(3);
            for (int i = 1; i <= 10; i++)
            {
                if (Flag == true)
                {
                    c = c * 2 + 7;
                    Console.WriteLine(c);
                }
                else
                {
                    c = c * 2 + 11;
                    Console.WriteLine(c);
                }

                Flag = !Flag;

            }
        }
    }
}
