using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ConditionalDemo
{
    class AlphabetDigitChar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the char");
            char ch = Convert.ToChar(Console.ReadLine());
             if(ch>='a'&& ch<='z'|| ch>='A'&& ch<='Z')
            {
                Console.WriteLine("Alphabet");
            }
            else if(ch>='0'&& ch<='9')
            {
                Console.WriteLine("Digit");
            }
            else 
            {
                Console.WriteLine("special character");
            }
        }
    }
}
