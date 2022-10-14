using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ConditionalDemo
{
    class Program
    {
        static void Main(string[]args)
        {
            int i = 4;
            int j = 2;

            int x = i++ + ++j - --i + j-- -i- --j;
            
            Console.WriteLine(x);
            Console.WriteLine(i);
            Console.WriteLine(j);


        }
    }
}
