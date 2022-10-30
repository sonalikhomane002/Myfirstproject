using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.AssinmentVloop
{
    class Q2OddSeries
    {
        static void Main(string[] args)
        {
            int num = 521;
            while(num>=229)
            {
                if(num%2!=0)
                {
                    Console.WriteLine(num);
                }
                num--;
            }

        }
    }
}
