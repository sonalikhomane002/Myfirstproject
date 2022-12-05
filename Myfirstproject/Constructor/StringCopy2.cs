using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Constructor
{
    //CopyTo
    class StringCopy2
    {
        static void Main(string[] args)
        {
            string str1 = "Hello World Programming";
            char[] str2 = new char[14];

            Console.WriteLine("string is"+str1);
            str1.CopyTo(6, str2, 0, 5);
            Console.WriteLine("Copied strig is");

            foreach(char c in str2)
                Console.Write(c);
               
        }
    }
}
