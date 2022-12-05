using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPsdemo
{
    class Dfrequency
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());

            int rem, cnt, t = -1;
            for (int i = 0; i <= 9; i++)
            {
                cnt = 0;
                for (int j = num; j > 0; j = j / 10)
                {
                    rem = j % 10;
                    if (rem == i)
                    {
                        t = i;
                        cnt++;

                    }
                }
                if (t == i)
                {
                    Console.WriteLine("The frequency of Digit" + i + "is" + cnt);

                }
            }
            Console.ReadKey();


            
        }
    }
}
