using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject
{
    class Class2
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

            for (int i = 1; i <= 5; i++)
            {
                for (int k = 1; k < i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 6 - i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

            //int i, s = 0;
            //for (i = 1; i <= 10; s = s + i, i++)
            //{
            //    Console.WriteLine(s);
            //}

            for (int i = 5; i > 0; i--)
            {
                int mysteryInt = 100;
                mysteryInt -= i;
                Console.WriteLine(mysteryInt);
            }



        }




    }

}
    
