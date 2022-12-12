using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.AssignmentOnString
{
    //To split string into 2 tokens where string is “HELLO$WORLD”
    class Program
    {
        static void Main(string[] args)
        {


            string str = "HELLO$WORLD";
            string[] res = str.Split('$');

            foreach (string words in res)
            {
                Console.WriteLine(words);
            }
        }
    }
    // find first occurrence of a character in a given string.
    class FirstOccuranceChar
    {
        static void Main(string[] args)
        {
            string str = "India country";

            
            int result = str.IndexOf("c");

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
    //count occurrences of a character in given string.
    class CharOccuranceString
    {
        public static void FindOccuranceChar(char[] ch)
        {

            for (int i = 0; i < ch.Length; i++)
            {
                int count = 1;
                bool flag = false;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (ch[i] == ch[k])
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == false)
                {
                    for (int j = i + 1; j < ch.Length; j++)
                    {
                        if (ch[i] == ch[j])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine(ch[i] + " " + count);
                }
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("enter  the string");
            string str = Console.ReadLine();
            char[] ch = str.ToCharArray();
            int count = 0;
            foreach (char c in ch)
            {
                Console.Write(c + " ");
                count++;
            }
            Console.WriteLine();
            Console.WriteLine(count);
            CharOccuranceString.FindOccuranceChar(ch);
        }
    }
    //trim leading white space characters in a string.
    class Program2
    {
        static void Main(string[] args)
        {


           string  myName = "     myName is SONALI";
            myName = myName.TrimStart();
            Console.WriteLine(myName + "  " + "Done");
        }
    }
    //to count total number of words in a string. 
    class WordString
    {
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
    class Task
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string ");
            string str = Console.ReadLine();


            for(int i=0;i<str.Length;i+=2)
            {
                Console.WriteLine(str[i]);
            }
        }

    }
    class Task23
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string str = Console.ReadLine();
            int cnt = str.Split(' ').Length;
            for (int i=0;i<str.Length;i++)
            {
                int count = 0;
                for(int j=0; j < str.Length;j++)
                {
                    if (str[j] == ' ')
                    {
                        count++;
                    }

                    if (count == i)
                    {
                        break;
                    }

                    Console.Write(str[j]);
                }
                if (cnt == i)
                {
                    break;
                }

                Console.WriteLine();
            }
           

        }
    }
    // Remove Trailingspace
    class Program23
    {
        static void Main(string[] args)
        {
           string  myName = "     myName is SONALI       ";
            myName = myName.Trim();
            Console.WriteLine(myName + "  " );
        }
    }
    class Progam24
    {

        static void Main(string[] args)
        {
         
            int i, len, vowels, consonants;
            string  str = "Dot net Programming";
            vowels = 0;
            consonants = 0;
            len = str.Length;

            
            for (i = 0; i < len; i++)
            {

                if (str[i] == 'a' || str[i] == 'e' ||
                    str[i] == 'i' || str[i] == 'o' ||
                    str[i] == 'u' || str[i] == 'A' ||
                    str[i] == 'E' || str[i] == 'I' ||
                    str[i] == 'O' || str[i] == 'U')
                {

                   vowels++;
                }

                else if ((str[i] >= 'a' && str[i] <= 'z') ||
                         (str[i] >= 'A' && str[i] <= 'Z'))
                { 
                    consonants++;
                }
            }

            Console.WriteLine("count of vowel = " + vowels);
            Console.WriteLine("count of consonant = " + consonants);
        }
        
    }
    class ReverseString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any word");
            string str = Console.ReadLine();

            string reverse = string.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverse += str[i];
            }
            Console.WriteLine(reverse);
        }
    }
}









