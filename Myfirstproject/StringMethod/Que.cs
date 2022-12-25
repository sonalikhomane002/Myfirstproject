using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StringMethod
{
    class Que
    {
        static void Main(string[] args)
        {
            string str = "chain kuli ki main kuli";
            char ch = 'k';

            int freq = 0;
            foreach (char c in str)
            {
                if (c == ch)
                {
                    freq++;
                }
            }

            Console.WriteLine(freq);
        }
    }
    //count occerance of word in string.
    class Task1111
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter string");
            string str1 = Console.ReadLine();
            Console.WriteLine("enter the words");
            string str = Console.ReadLine();
            

            string[] words = str1.Split(' ');
            int count = 0;
            for (int i = 0; i < words.Length; i++)
            {
               

                if (str == words[i])
                {
                    count++;
                }

            }
            Console.WriteLine(count);


        }
        
    }
}
