using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StringMethod
{
    class String
    {
        static void Main(string[] args)
        {
            string myName = "myName is sonali";
            myName = myName.ToUpper();
            Console.WriteLine(myName);

            myName = "myName is DHRUV";
            myName = myName.ToLower();
            Console.WriteLine(myName);

            myName = "     myName is SONALI       ";
            myName = myName.Trim();
            Console.WriteLine(myName);

            myName = "     myName is SONALI       ";
            myName = myName.TrimEnd();
            Console.WriteLine(myName + "  " + " Done");

            myName = "     myName is SONALI       ";
            myName = myName.TrimStart();
            Console.WriteLine(myName + "  " + " Done");

            myName = "myName is SONALI";
            bool isContains = myName.Contains("SONALI1");
            Console.WriteLine(isContains);

            myName = "myName is SONALI";
            char[] charArray = myName.ToCharArray();
            foreach (char c in charArray)
            {
                Console.WriteLine(c);
            }
            myName = "myName is SONALI";
            myName = myName.Substring(0, 6);
            Console.WriteLine(myName);


            myName = "myName is SONALI";
            isContains = myName.StartsWith("my");
            Console.WriteLine(isContains);

            myName = "myName/is/SONALI";
            string[] breakMysentence = myName.Split('/');
            foreach (string data in breakMysentence)
                Console.WriteLine(data);



            Console.ReadKey();
        }
    }
}
