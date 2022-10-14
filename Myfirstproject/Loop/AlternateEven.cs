using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loop
{
    class AlternateEven
    {
        //Alternate even num between 1 to 20
        //2,6,10,14,18
        static void Main(string[] args)
        {
            for (int i = 2; i <= 20; i = i + 4)
            {
                Console.WriteLine(i);
            }
        }
    }
}
