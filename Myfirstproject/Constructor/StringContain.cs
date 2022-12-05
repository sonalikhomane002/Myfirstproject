using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Constructor
{
    //chech given word is prsent in strin or not
    class StringContain
    {
        static void Main(string[] args)
        {
            string str = "Hello world Programming";
            Console.WriteLine("String is ="+str);

            //contain
            Console.WriteLine("enter string to be found in present string");
            string strFound = Console.ReadLine();

            bool ispresent = str.Contains(strFound);
                if(ispresent)
                Console.WriteLine(strFound+"is present in str");
                else
                Console.WriteLine(strFound + "is  not present in str");

        }
    }
}
