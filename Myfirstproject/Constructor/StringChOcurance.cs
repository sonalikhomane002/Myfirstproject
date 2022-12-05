using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Constructor
{
    class StringChOcurance
    {
        static void Main(string[] args)
        {
            string str = "Hello World";
          // for(int i=0;i<str.Length;i++)
           
               // Console.Write(str[i]);
            Console.WriteLine();

           // Console.WriteLine("enter the character");
            //char ch = char.Parse(Console.ReadLine());
            /*int count = 0;
            for(int i=0;i<str.Length;i++)
            {
                if(ch==str[i])
                {
                    count++;
                }

            }
            if(count==0)
                Console.WriteLine("Ch is not present");
            else
                Console.WriteLine("ch is present"+count+"times");*/

            for(int i=0;i<str.Length;i++)
                if(char.IsUpper(str[i]))
                    Console.WriteLine(char.ToLower(str[i]));
            else
                    Console.WriteLine(char.ToUpper(str[i]));
        }
        
    }
}
