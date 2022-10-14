using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loop
{
    class Switchdemo2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the char");
            char ch = Convert.ToChar(Console.ReadLine());

            switch (ch)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                    Console.WriteLine("vowel");
                    break;
                default:
                    Console.WriteLine("consonent");
                    break;
            }
        }
    }
}
