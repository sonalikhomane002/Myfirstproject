using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string str ="Hello";
            string str2 = "hello";
            int x = str.CompareTo(str2);
            Console.WriteLine(x);//1

            int y = str2.CompareTo(str);
            Console.WriteLine(y);//-1


            /* string str ="Hello";
             string str2 = "Hello";

             string s = new string("pune");
             Console.WriteLine(str+" "+str2);
             Console.WriteLine(str==str2);
             Console.WriteLine(str.Equals(str2));
             Console.WriteLine(str.GetHashCode());
             str = str + ".net";
             Console.WriteLine(str.GetHashCode());
             Console.WriteLine(str+" "+str2);
             Console.WriteLine(str==str2);
             Console.WriteLine(str.Equals(str2));*/
        }
    }
    class Program2
    {
        static void Main(string[] args)
        {
            string str = "I like india country";
            string s = str.ToUpper();
            Console.WriteLine(s);
            string s1 = str.ToLower();
            Console.WriteLine(s1);
            char[] ch = str.ToCharArray();
            foreach(char c in ch)
            {
                Console.Write(c+" ");
            }
            Console.WriteLine(str.Substring(4));
            Console.WriteLine("......................");
            Console.WriteLine(str.Substring(4,6));

            string[] mywords = str.Split(",");
            foreach(string w in mywords)
            {
                Console.WriteLine(w);
            }
            Console.WriteLine(str.IndexOf('b'));
            Console.WriteLine(str[4]);
            Console.WriteLine(str.Replace("like","love"));

            Console.WriteLine(str.Contains("Like"));
            Console.WriteLine(str);
            Console.WriteLine(str.Trim());
        }
    }
    class Program3
    {
        public string Doreverse(string s)
        {
            char[] ch = s.ToCharArray();
            string s2 = "";
            for (int i = 0; i < ch.Length; i++)
            {
                s2 = ch[i] + s2;
            }
            return s2;
        }

        static void Main(string[] args)
        {
            // Console.WriteLine("Enter the String");
          //  Console.ReadLine();
            Program3 obj = new Program3();
            string str = "My country is india"; 
             str= Console.ReadLine();
            Console.WriteLine(obj.Doreverse(str));
            

        }
    }
    class Program6
    {
        public void ToStringConvert(char[] ch)
        {
            string s = new string(ch);
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String");
            string str = Console.ReadLine();
            Program6 obj = new Program6();
            char[] ch = str.ToCharArray();
            Console.WriteLine(string.Join(" ", ch));
            obj.ToStringConvert(ch);

        }
    }

    class Program4
    {
        //count no of char
        static void Main(string[] args)
        {
            string str = "Dot net Programming";
            char[] ch = str.ToCharArray();
            int count = 0;
            foreach (char c in ch)
            {
                Console.Write(c + " ");
                count++;
            }
            Console.WriteLine();
            Console.WriteLine(count);

        }
    }
    class Program5
    {
        //count no of word in string
        static void Main(string[] args)
        {
            string str = "Dot net Programming";

            string[] mywords = str.Split();
            int count = 0;
            foreach (string w in mywords)
            {
                Console.WriteLine(w);
                count++;
            }
            Console.WriteLine();
            Console.WriteLine(count);


        }
    }
    class Program22
    {
        //abbreviated form of person name
        static void Main(string[] args)
        {
            string s = "Sonali Dattatraya Khomane";
            string[] words = s.Split(' ');
            for (int i = 0; i < words.Length - 1; i++)
            {
                words[i] = words[i].Substring(0, 1);
            }
           string s1= string.Join(".", words);
           Console.WriteLine(s1);
        }
    }
    class DigitAddition
    {
        //digit addition in string
        public static int FindDigit_Sum(string s)
        {
            int sum = 0;
            for(int i=0;i<s.Length;i++)
            {
                if(char.IsDigit(s[i]))
                {
                    sum = (int)(sum + char.GetNumericValue(s[i]));
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string str = Console.ReadLine();
            Console.WriteLine(" "+str);
            Console.WriteLine("sum of Digit"+DigitAddition.FindDigit_Sum(str));

        }

    }
    class PalindromeString
    {
        static void Main(string[] args)
        {
           
            
        }
    }








}
