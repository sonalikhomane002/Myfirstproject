using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StringMethod
{
    class Que
    {
        static void Main(string[] args)
        {
            string str = "chain kuli ki main kuli";
            char ch = 'k';

            int freq = 0;
            foreach (char c in str)
            {
                if (c == ch)
                {
                    freq++;
                }
            }

            Console.WriteLine(freq);
        }
    }
}
