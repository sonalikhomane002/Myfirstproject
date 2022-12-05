using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Constructor
{
    class StringPrograms
    {
        static void Main(string[] args)
        {
            /*   string str = "Hello";
                 Console.WriteLine("String is "+str);
                 int len = 0;
                 foreach(char ch in str)
                 {
                 Console.Write(ch);
                 len++;
                 }
                 Console.WriteLine("String length is= "+ len);*/
            //
            //using str.Length Property
            //
/*            string str = "Hello";
            Console.WriteLine("String is " + str);
            Console.WriteLine("String Length is= "+str.Length);

            for(int i=0;i<str.Length;i++)
                Console.Write(str[i]);
            Console.ReadKey();*/

            //display the alternate character from string

            string str = "Hello World";
            Console.WriteLine("String is " + str);

            for (int i = 0; i < str.Length; i+=2)
                Console.Write(str[i]);
            Console.ReadKey();
        }
    }
}
