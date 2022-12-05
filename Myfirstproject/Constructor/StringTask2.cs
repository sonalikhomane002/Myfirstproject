using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Constructor
{
    //Sum of int value  in string
    class StringTask2
    {
        static void Main(string[] args)
        {
            string str = "Hello12 World6 Programming";
            Console.WriteLine("String is="+str);

            int sum = 0;
            foreach(char ch in str)
            {
                if(ch>=48&&ch<=57)
                {
                    sum = sum + int.Parse(ch.ToString());

                }
               // Console.WriteLine("Digits of sum present in string="+sum);
            }
            Console.WriteLine("Digits of sum present in string=" + sum);


        }
    }
}
