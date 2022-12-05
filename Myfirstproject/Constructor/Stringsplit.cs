using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Constructor
{
    //split method
    class Stringsplit
    {
        static void Main(string[] args)
        {
            string str = "Hello world Programming";
            Console.WriteLine("String is="+str);

            string[] strArr = str.Split(' ');
            Console.WriteLine("Number of present in {0} is {1} ",str,strArr.Length);

            foreach(string str2 in strArr)
                Console.WriteLine(str2);

            Console.ReadKey();
        }
    }
}
