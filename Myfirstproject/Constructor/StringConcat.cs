using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Constructor
{
    class StringConcat
    {
        static void Main(string[] args)
        {
            string str1 = "Hello";
            string str2 = "World";

            string str = "";

            foreach (char ch in str1)
                str = str + ch;

            foreach (char ch in str2)
                str = str + ch;

            Console.WriteLine("Concatinated string is "+str);

        }
    }
    // 2 method for concat
    class Strincon
    {
        static void Main(string[] args)
        {
            string str1 = "Hello";
            string str2 = "World";

           // string str = "";

            foreach (char ch in str2)
                str1 = str1 + ch;
            Console.WriteLine("Concatinated string is " + str1);

        }
    }
    class StringCon2
    {
        static void Main(string[] args)
        {
            string str1 = "Hello ";
            string str2 = "World ";
            string str3 = "Programming";

            string[] strArr = new string[3];
            strArr[0] = str1;
            strArr[1] = str2;
            strArr[2] = str3;

            string str = string.Concat(strArr);
            Console.WriteLine("Concatinated string is"+str);


        }
    }
    class StringC
    {
        static void Main(string[] args)
        {
            string str1 = "Hello ";
            string str2 = "World ";
            string str3 = "Programming";

            string str = str1 + str2 + str3;
            
            Console.WriteLine("Concatinated string is=" + str);
            Console.ReadKey();

        }
    }
    //index of string and ch
    class SringIndex
    {
        static void Main(string[] args)
        {
            string str1 = "hello world";
            string str2 = "world";

            int position = str1.IndexOf(str2);

            Console.WriteLine("word position in String="+position);
        }
    }
    class StringComparision
    {
        static void Main(string[] args)
        {
            string str1 = "ABB";
            string str2 = "ABD";



            int comparision = string.Compare(str1, str2);
            if(comparision==0)
                Console.WriteLine("Both the string are equal");
            else
                if(comparision<0)
                Console.WriteLine("less than 0 first string preceeded the second string in sort order");
            else
                Console.WriteLine("greater than 0 second string precedded the first thing in sort oder");
        }
    }
    class StringCopy
    {
        static void Main(string[] args)
        {
            string str1 = "hello";
            string str2 = "";

            str2 =string.Copy(str1);
            Console.WriteLine("copied string is="+str2);

        }
    }



}
