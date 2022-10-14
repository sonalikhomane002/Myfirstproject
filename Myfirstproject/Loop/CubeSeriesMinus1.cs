using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loop
{
    class CubeSeriesMinus1
    {
        static void Main(string[] args)
        {
            //0,7,26,63...........
            for (int i = 1; i <= 10; i++)
            {
                Console.Write((i * i * i)-1);
                Console.Write(", ");
            }
        }
    }
}
