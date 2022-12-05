using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Constructor
{
    //count space in string
    class StringTask
    {
        static void Main(string[] args)
        {
            string str = "Hello world";

            Console.WriteLine("string is="+str);

            int count = 1;
            for(int i=0;i<str.Length;i++)
            {
                if(str[i]==' ')
                count++;
            }
            Console.WriteLine("Total number of words are="+count);

        }
    }
}
