using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPsdemo
{
    class PrintAlphabet
    {
        static void Main(string[] args)
        {
            char ch;

            for (ch = 'a'; ch <= 'z'; ++ch)
            {
                Console.WriteLine(ch + " ");
            }
        }
    }
    
}
