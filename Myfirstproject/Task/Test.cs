using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Task
{
    //Reverse string except 1st & 2nd string
    class Test
    {
        public string Doreverse(string s)
        {
            char[] ch = s.ToCharArray();
            string s2 = "";
            for(int i=0;i<ch.Length; i++)
            {
                s2 = ch[i] + s2;
            }
            return s2;
        }
        public string ReverseWord(string s)
        {
            string[] str = s.Split();
            string mywords = "";
            for(int i=0;i<str.Length;i++)
            {
                string wordvalue = str[i];
                string revword = "";
                for(int j=0;j<wordvalue.Length;j++)
                {
                    revword = wordvalue[j] + revword;
                }
                mywords = mywords + " " + revword;
            }
            return mywords;
        }
        static void Main(string[] args)
        {
             Console.WriteLine("Enter the String");
            string str = Console.ReadLine();
            Test r = new Test();
            //Console.WriteLine(r.Doreverse(str));
            //Console.WriteLine(r.ReverseWord(str));
            string[] word = str.Split(' ');
            Console.Write(word[0]); ;
            for(int i=1;i<word.Length-1;i++)
            {
                Console.Write(r.ReverseWord(word[i]));          
            }
            Console.Write(" "+ word[word.Length-1]); 


            char[] ch = str.ToCharArray();


            //Console.WriteLine(str);
        }
    }
}
