using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Writtentest17Nov
{
    //Accept a sentence from user and write a logic to do sum of numbers
    //e.g) str=”my name25 is4 Rishi450”
    //output: 479

    class Task
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String = ");
            string str = Console.ReadLine();
            int count, sum = 0;
            for (count = 0; count < str.Length; count++)
            {
                if ((str[count] >= '0') && (str[count] <= '9'))
                {
                    sum += (str[count] - '0');
                }
            }
            Console.WriteLine("Sum of String Digit = " + sum);
        }


    }

    // Predict the output of the following program.
    class Program
    {
        int count = 0;

        void A()
        {
            try
            {
                count++;

                try
                {
                    count++;

                    try
                    {
                        count++;
                        throw new Exception();

                    }

                    catch (Exception ex)
                    {
                        count++;
                        throw new Exception();
                    }
                }

                catch (Exception ex)
                {
                    count++;
                }
            }

            catch (Exception ex)
            {
                count++;
            }

        }

        void display()
        {
            Console.WriteLine(count);
        }

        static void Main(String[] args)
        {
            Program obj = new Program();
            obj.A();
            obj.display();
        }
    }
    //WAP to check if two Strings are anagrams of each other?
    class StringAnagram
    {
        public static bool IsAnagram(string s1, string s2)
        {

            char[] ch1 = s1.ToLower().ToCharArray();
            Array.Sort(ch1);

            char[] ch2 = s2.ToLower().ToCharArray();
            Array.Sort(ch2);

            if (ch1.Length == ch2.Length)
            {
                Console.WriteLine(string.Join(" ", ch1));
                Console.WriteLine(string.Join(" ", ch2));
                string str = new string(ch1);
                string str2 = new string(ch2);

                Console.WriteLine(str + "  " + str2);

                if (str.Equals(str2))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first string ");
            string s1 = Console.ReadLine();
            Console.WriteLine("enter the second string");
            string s2 = Console.ReadLine();

            bool flag = StringAnagram.IsAnagram(s1, s2);
            Console.WriteLine(flag);

            if (flag)
            {
                Console.WriteLine("both string are Anagram");
            }
            else
            {
                Console.WriteLine("Not Anagram");
            }

        }
    }
    //Accept a string print following pattern
    // e.g str =”ESHAN”

    class Program2
    {
        static void Main(string[] args)
        {
            string str = "ESHAN";
            int k = 1;
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(str[j] + " ");
                }
                Console.WriteLine("");
            }
            for (int i = str.Length; i >= 0; i--)
            {
                for (int j = 0; j <= str.Length - k; j++)
                {
                    Console.Write(str[j] + " ");
                }
                Console.WriteLine("");
                k++;
            }
        }
    }
    //Write a  program or function which takes two strings as input and
    //print common characters between them in alphabetical order.
    //For example, if "thin sticks" and "thick bricks" are two given
    //input strings then common characters between them in alphabetical order are    
    // [c, h, i, k, s, t]. 

    class Program3
    {
        static void Printcommon(string s1, string s2)
        {
            char[] ch1 = s1.ToLower().ToCharArray();
            char[] ch2 = s2.ToLower().ToCharArray();
            List<char> datalist = new List<char>();

            bool flag = false;
            for (int i = 0; i < ch1.Length; i++)
            {

                for (int j = 0; j < ch2.Length; j++)
                {
                    if (ch1[i] == ch2[j])
                    {
                        flag = false;
                        
                        
                        for (int k = 0; k <= datalist.Count-1; k++)
                        {
                            if (datalist[k] == ch2[j])
                            {
                                flag = true;
                            }
                        }

                        if (!flag)
                        {
                            datalist.Add(ch2[j]);
                        }
                    }
                }


            }
            datalist.Sort();

            foreach (var item in datalist)
            {
                Console.WriteLine(item);
            }


        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first string ");
            string s1 = Console.ReadLine();
            Console.WriteLine("enter the second string");
            string s2 = Console.ReadLine();
            Program3.Printcommon(s1, s2);
        }
    }
    //what is the throw keyword with example
    class ThrowDemo
    {
        public static void check(int age)
        {
            if (age < 18)
            {
                throw new Exception("Invalid age for Driving ");
            }
            else
            {
                Console.WriteLine("age is valid for Driving test.......");
            }

        }
        static void Main(string[] args)
        {
            try
            {
                ThrowDemo.check(20);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
    //q22.	How do you create customized exceptions ?
    class NumberNotAllowedException : SystemException
    {
        public NumberNotAllowedException()
        {
            Console.WriteLine("digit not allowed in Text");


        }
    }
    class customDemo2
    {
        public static void check(string s)
        {
            bool ispresent = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                {
                    ispresent = true;
                    break;

                }
            }
            if (ispresent == true)
            {
                throw new NumberNotAllowedException();
            }
            Console.WriteLine("valid string");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string s = Console.ReadLine();
            try
            {
                check(s);
            }
            catch
            {
                Console.WriteLine("handle....");
            }
        }
    }
    //Q3 Nullpointer exception
    class Program9
    {
        static void Main(string[] args)
        {
            string str = null;
            try
            {
                Console.WriteLine(str.Substring(5));
            }
            catch (NullReferenceException err)
            {
                Console.WriteLine("Please check the string str.");
                Console.WriteLine(err.Message);
            }
            Console.WriteLine("Continuing with other statments..");
        }
    }
    class Assgn17DQ2
    // 6.Accept a sentence from user and write a logic to do sum of numbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String :");
            string str = Console.ReadLine();
            int sum = 0;
            foreach (char ch in str)
            {
                if (ch >= 48 && ch <= 57)
                    sum = sum + int.Parse(ch.ToString());
            }
            Console.WriteLine("Sum of digits presen in string = " + sum);
        }
    }
    class Assgn17DQ5
    /* Write a  program or function which takes two strings as input
     and print common characters between them in alphabetical order. */
    {
        static int MAX_CHAR = 26;
        static void printCommon(string s1, string s2)
        {
            int[] a1 = new int[MAX_CHAR];
            int[] a2 = new int[MAX_CHAR];
            int length1 = s1.Length;
            int length2 = s2.Length;
            for (int i = 0; i < length1; i++)
                a1[s1[i] - 'a'] += 1;
            for (int i = 0; i < length2; i++)
                a2[s2[i] - 'a'] += 1;
            for (int i = 0; i < MAX_CHAR; i++)
            {
                if (a1[i] != 0 && a2[i] != 0)
                {
                    for (int j = 0; j < Math.Min(a1[i], a2[i]); j++)
                        Console.Write(((char)(i + 'a')) + " ");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string 1 :");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter string 2 :");
            string s2 = Console.ReadLine();
            printCommon(s1, s2);
        }
    }
}


























