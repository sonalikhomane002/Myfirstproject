using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Assignment2
{
    class Q7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter th ch");
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("vowel");
            }

            else
            {
                Console.WriteLine("consonent");
            }

        }
    }
}
