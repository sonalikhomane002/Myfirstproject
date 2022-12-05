using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPsdemo
{
    class AlphabetDigit
    {
      
        public char ch { get; set; }
        public void Check()
        {
            if (ch >= 65 && ch <= 90)
            {
                Console.WriteLine((char)ch + " is uppercase charcter");
            }
            else if (ch >= 97 && ch <= 122)
            {
                Console.WriteLine((char)ch + " is lower case character");
            }
            else if (ch >= 48 && ch <= 57)
            {
                Console.WriteLine(ch + " is digit");
            }
            else
            {
                Console.WriteLine(ch + " is symbol");
            }
        }
        static void Main(string[] args)
        {
            AlphabetDigit c = new AlphabetDigit();
            Console.WriteLine("Enter the character: ");
            c.ch = char.Parse(Console.ReadLine());
            c.Check();
        }
    }
}

