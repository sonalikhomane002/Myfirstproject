using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Constructor
{
    //display index  of ch in string
    class StringIndex
    {
        static void Main(string[] args)
        {
            string str = "Hello";
            Console.WriteLine("String is="+str);

            
            Console.WriteLine("enter the ch to search");
            char ch = char.Parse(Console.ReadLine());
            
            for(int i=0;i<str.Length;i++)
            {
                if(ch==str[i])
                {
                    Console.WriteLine("Zero based index position is "+i);
                    break;
                }
                Console.ReadKey();
            }
        }
    }
}
