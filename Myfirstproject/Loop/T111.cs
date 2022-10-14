using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loop
{
    class T111
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {

                sum = (sum * 10) + 1;
                Console.WriteLine(" ");

                
            }
            Console.WriteLine(sum);
        }
    }
}
