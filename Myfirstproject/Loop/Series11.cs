using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loop
{
    class Series11
    {
        static void Main(string[] args)
        {
            //1,3,7,15,23.........
            int p = 2;
            for(int i=1; i<=50;)
            {
                Console.WriteLine(i);
                i = i + p;
                p = p * 2;
            }


        }
    }
}
