using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPsdemo
{
    class AlphabetDigitChar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the character");
            int ch;
            ch = Convert.ToChar(Console.ReadLine());

            if((ch >= 65 && ch <= 90)||(ch >= 97 && ch <= 122))
            {
                Console.WriteLine("this is a character");
            }
            else if ((ch >= 48 && ch <= 57))
            {
                Console.WriteLine("numeric erntred");
            }
            else
            {
                Console.WriteLine("special Symbol");
            }
        }
    }
}
