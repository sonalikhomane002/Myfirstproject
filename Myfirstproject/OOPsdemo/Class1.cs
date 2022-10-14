using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPsdemo
{
    class Class1
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
                Console.WriteLine(i);
                display(i);
            }
        }

        public static void display(int x)
        {
            Console.WriteLine(x);
        }
    }
}
