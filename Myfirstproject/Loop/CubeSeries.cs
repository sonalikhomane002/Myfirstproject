using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loop
{
    class CubeSeries
    {
        //1,8,27,64........
        static void Main(string[] args)
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.Write(i*i*i);
                Console.Write(" , ");
            }
        }
    }
}
