using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello";
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
            foreach (char c in ch)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine(str.Substring(4));
            Console.WriteLine("......................");
            Console.WriteLine(str.Substring(4, 6));

            string[] mywords = str.Split(",");
            foreach (string w in mywords)
            {
                Console.WriteLine(w);
            }
            Console.WriteLine(str.IndexOf('b'));
            Console.WriteLine(str[4]);
            Console.WriteLine(str.Replace("like", "love"));

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
            str = Console.ReadLine();
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
        //count no of char from string
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
            string s1 = string.Join(".", words);
            Console.WriteLine(s1);
        }
    }
    class DigitAddition
    {
        //digit addition in string
        public static int FindDigit_Sum(string s)
        {
            int sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
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
            Console.WriteLine(" " + str);
            Console.WriteLine("sum of Digit" + DigitAddition.FindDigit_Sum(str));

        }

    }
    class RevStr
    {
        //Reverse string except 1st & 2nd string
        public string ReverseWord(string s)
        {
            string[] str = s.Split();
            string mywords = "";
            for (int i = 0; i < str.Length; i++)
            {
                string wordvalue = str[i];
                string revword = "";
                for (int j = 0; j < wordvalue.Length; j++)
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
            for (int i = 1; i < word.Length - 1; i++)
            {
                Console.Write(r.ReverseWord(word[i]));
            }
            Console.Write(" " + word[word.Length - 1]);


        }

    }
    class StrPattern
    {
        // i
        //i like
        //i like india
        //i like india country
        static void Main(string[] args)
        {
            string str = "i like india country";
            int cnt = str.Split(' ').Length;
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                count = 0;
                for (int j = 0; j < str.Length; j++)
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
    class Vowel
    {
        //number of vowels from string
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();

            int vowelcount = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i'
                    || str[i] == 'o' || str[i] == 'u' || str[i] == 'A'
                    || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U')
                {
                    vowelcount++;
                }

            }
            Console.WriteLine(vowelcount);
            Console.ReadKey();

        }
    }
    class PalindromeStr
    {
        //check given string is palindrome or not
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any word");
            string str = Console.ReadLine();

            string reverse = string.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverse += str[i];
            }

            if (str == reverse)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
        }
    }
    class MutableString
    {
        //check string is palindrome or not using stringbuilder
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string str = Console.ReadLine();
            StringBuilder sb = new StringBuilder(str);
            string rev;
            char[] ch = str.ToCharArray();
            Array.Reverse(ch);
            rev = new string(ch);
            bool check = str.Equals(rev, StringComparison.OrdinalIgnoreCase);
            if (check == true)
            {
                Console.WriteLine(" " + sb + " is a palindrome string");
            }
            else
            {
                Console.WriteLine(" " + sb + " is not a palindrome string");
            }
        }
    }

    class AverageOfDigit
    {
        //Average of digit in string
        public static float FindDigit_Sum(string s)
        {
            int sum = 0;
            int count = 0;
            float average = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                {

                    count++;
                    sum = (int)(sum + char.GetNumericValue(s[i]));


                }
            }
            average = (float)sum / count;
            return average;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string str = Console.ReadLine();
            Console.WriteLine(" " + str);
            Console.WriteLine("sum of Digit " + DigitAddition.FindDigit_Sum(str));
            Console.WriteLine("Average of digit in string" + AverageOfDigit.FindDigit_Sum(str));
        }
    }
    class charoccur
    {
        //find charoccurance  of char in string

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
            charoccur.FindOccuranceChar(ch);
        }
    }

    class ValidString
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter  the String");
            string numberStr = Console.ReadLine();


            bool isValid = true;

            for (int i = 0; i < numberStr.Length; i++)
            {
                if (!char.IsDigit(numberStr[i]))
                {
                    isValid = false;
                    break;

                }
            }
            int sum = 0;

            int sum1 = 0;
            if (isValid && numberStr.Length >= 3)
            {
                for (int i = 0; i < 3; i++)
                {

                    sum += (int)char.GetNumericValue(numberStr[i]);
                }
                Console.WriteLine(sum);
                for (int i = 0; i < 3; i++)
                {

                    sum1 += (int)char.GetNumericValue(numberStr[numberStr.Length - i - 1]);

                }

                Console.WriteLine(sum1);
            }
            else
            {
                Console.WriteLine("invalid string");
            }

            if (sum == sum1)
            {
                Console.WriteLine("equal");
            }
            else
            {
                Console.WriteLine("not equal");
            }

        }
    }
    class SortString
    {
        public static void LengthSort(string s)
        {
            string[] st = s.Split();
            Console.WriteLine(string.Join(" ", st));
            for (int i = 0; i < st.Length; i++)
            {
                for (int j = i + 1; j < st.Length; j++)
                {
                    if (st[i].Length > st[j].Length)
                    {
                        string temp = st[i];
                        st[i] = st[j];
                        st[j] = temp;
                    }
                }
            }

            int cnt = 0;
            for (int i = st.Length - 1; i >= 0; i--)
            {
                if (i > 0 && st[i].Length == st[i - 1].Length)
                {
                    Console.Write(" " + st[i]);
                    cnt++;
                }
            }

            if (cnt >= 1 || cnt == 0)
            {
                Console.WriteLine(" " + st[st.Length - 1]);
            }


        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string str = Console.ReadLine();
            SortString.LengthSort(str);
        }
    }
    class LongestWord
    {   // write code to find out the longest word from the string

        static void Main(string[] args)
        {
            Console.WriteLine("Enter string :");
            string str = Console.ReadLine();
            string[] words = str.Split(new[] { " " }, StringSplitOptions.None);
            string word = "";
            int count = 0;
            foreach (String s in words)
            {
                if (s.Length > count)
                {
                    word = s;
                    count = s.Length;
                }
            }
            Console.WriteLine("Longest word from string : " + word);
        }
    }

}














