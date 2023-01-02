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
            

            Dictionary<string, string> dl = new Dictionary<string, string>();
            string[]words= str1.Split(' ');
        
            for (int i = 0; i < words.Length; i++)
            {
               for(int j=i+1;j<words.Length;j++)
                {
                    if(words[i]==words[j])
                    {

                        if (!dl.ContainsKey(words[i].ToString()))
                        {
                            dl.Add(words[i].ToString(), words[i].ToString());
                        }
                       
                    }
                }

                

            }
            foreach (KeyValuePair<string, string> item in dl)
            {
                Console.WriteLine(item.Key.ToString());
            }
        


        }
        
    }
}
