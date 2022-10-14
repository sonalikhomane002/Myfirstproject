using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loop
{
    class PatternTask1
    {
        static void Main(string[] args)
        {
            /*1 1 1 1
              2 2 2 2
              3 3 3 3
              4 4 4 4*/


            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    Console.Write(i+" ");
                }
                Console.WriteLine();

            }
        }
    }

}
    

    
    

