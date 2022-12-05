using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loop
{
    class Prime1to10
    {
        static void Main(string[] args)
        {
            for (int no = 2; no <= 20; no++)
            {

                int cnt = 2, prime = 1;

                while (cnt <= no / 2)
                {

                    if (no % cnt == 0)
                    {
                        prime = 0;
                        break;

                    }
                    cnt++;
                }
                if (prime == 1)
                {
                    Console.Write(no + " ");
                }
            }
        }
    }
}
