using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loop
{
    class IntegerPattern
    {
        static void Main(string[] args)
        {
           
            for(int i=1;i<=5;i++)
            {
                int n = 5;
                for (int j=1;j<=6-i;j++)
                {
                    Console.Write(n);
                    n--;
                }
                Console.WriteLine();
            }
        }
    }
}
