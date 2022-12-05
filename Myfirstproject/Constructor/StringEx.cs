using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Constructor
{
    //StringBehavior example
    class StringEx
    {
        static void Main(string[] args)
        {
            string str = "sonali";
            string str1 = "sonali";

            Console.WriteLine("Reference for str " + str.GetHashCode());
            Console.WriteLine("Reference for str1 " + str1.GetHashCode());

            str = str + "Dhumal";
            Console.WriteLine("Reference for str " + str.GetHashCode());
            Console.WriteLine("Reference for str1 " + str1.GetHashCode());

            str = str + "Dhumal";
            str = str + "Lives in Pune";
            str = str + "is a Engineer";
            Console.WriteLine("Reference for str " + str.GetHashCode());

            StringBuilder sb = new StringBuilder();
            sb.Append("hello world");
            Console.WriteLine("Reference for sb" + str.GetHashCode());
            sb.Append("c#");
            sb.Append("Programming");
            Console.WriteLine("String is "+sb.ToString());
            Console.WriteLine("Reference for sb"+str.GetHashCode());
            //no reference is created in this way stringbilder is mutable
            Console.ReadKey();
        }
    }
}
