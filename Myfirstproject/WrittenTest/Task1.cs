using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.WrittenTest
{

    //	Write a program to count the number of words in a string
    class Q2
    {
        static void Main(string[] args)
        {
            string str = "i like india country";

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
    //Write a  program to check whether two strings are anagram or not?
    class StringAnagram
    {
        public static bool IsAnagram(string s1, string s2)
        {
            char[] ch1 = s1.ToLower().ToCharArray();
            char[] ch2 = s2.ToLower().ToCharArray();

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
                Console.WriteLine("Not");
            }

        }
    }

    //Write a  program to convert uppercase string to lowercase
    class Task4
    {
        static void Main(string[] args)
        {
            string str1 = "DotNetProgramming";

            string lowerstr1 = str1.ToLower();

            Console.WriteLine(lowerstr1);
        }
    }
    //Write a  program to enter two numbers and find their sum.
    class Task5
    {
        static void Main(string[] args)
        {
            int sum;
            Console.WriteLine("Enter the First Number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second Number");
            int num2 = int.Parse(Console.ReadLine());

            sum = num1 + num2;
            Console.WriteLine("Sum of Two Number is= " + sum);

        }
    }
    //Write a  program to enter two numbers and perform all arithmetic operations
    //Different Program for each .
    class Task6
    {
        static void Main(string[] args)
        {
            int addition;
            Console.WriteLine("enter the num1=");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num2=");
            int num2 = Convert.ToInt32(Console.ReadLine());
            addition = num1 + num2;
            Console.WriteLine(addition);


        }
    }
    class Substraction
    {
        static void Main(string[] args)
        {
            int subtraction;
            Console.WriteLine("enter the num1=");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num2=");
            int num2 = Convert.ToInt32(Console.ReadLine());
            subtraction = num1 - num2;
            Console.WriteLine(subtraction);

        }
    }
    class Division
    {
        static void Main(string[] args)
        {
            int Division;
            Console.WriteLine("enter the num1=");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num2=");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Division = num1 / num2;
            Console.WriteLine(Division);


        }
    }
    class Multiplication
    {
        static void Main(string[] args)
        {
            int multiplication;
            Console.WriteLine("enter the num1=");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num2=");
            int num2 = Convert.ToInt32(Console.ReadLine());
            multiplication = num1 * num2;
            Console.WriteLine(multiplication);


        }
    }
    //program to enter length and breadth of a rectangle and find its Area
    class AreaOfRectangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the length of a rectan gle: ");
            int Length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the breadth of a rectangle: ");
            int Breadth = Convert.ToInt32(Console.ReadLine());
            int Area = Length * Breadth;
            Console.WriteLine(Area);
        }
    }
    //program to enter base and height of a triangle and find its area..
    class AreaOfTriangle
    {
        static void Main(string[] args)
        {

            Console.Write("enter the base:");
            double Base = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter the Height:");
            double Height = Convert.ToDouble(Console.ReadLine());

            double Area = (Base * Height) / 2;
            Console.Write("area of a triangle = " + Area);

        }
    }
    //Program to calculate Square of given number
    class SquareNum
    {
        static void Main(string[] args)
        {
            int square;

            int number = 2;
            square = number * number;
            Console.WriteLine("Square of Number is " + square);

        }
    }
    //Program to calculate cube of given number
    class Task23
    {
        static void Main(string[] args)
        {
            int cube;
            int num = 2;
            cube = num * num * num;
            Console.WriteLine("cube of number is = " + cube);

        }
    }
    class Task
    {
        static void Main(string[] args)
        {
            double meter, kilometer;
            Console.WriteLine("enter length in centimeter");
            float Cm = float.Parse(Console.ReadLine());
            meter = Cm / 100.0;
            kilometer = Cm / 100000.0;
            Console.WriteLine(meter);
            Console.WriteLine(kilometer);

        }
    }
    class Task34
    { //Write a  program to find the duplicate words and their number of occurrences in a string
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string :");
            string str = Console.ReadLine();
            string[] words = str.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < words.Length; j++)
                {
                    if (words[i] == words[j])
                    {
                        count++;
                    }
                }
                if (count > 1)
                {
                    Console.WriteLine(words[i] + " occurs " + count + " times");
                }
            }
        }
    }
    class Task55
    {//	Create an array of 10 names sort in descending order

        static void Main(string[] args)
        {
            string[] str = { "sonali", "anisha", "ganesh", "disha", "komal",
                "sona","vedant","dhruv","mahesh","amol"};

            Array.Sort(str);
            Array.Reverse(str);

            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }


        }
    }
    //7WAP to reverse the array itself, don’t print array in reverse –
    //I want current array reverse. Means e.g. arr[] = [3, 90, 45, 29, 37, 78]
    //so your same array must be [78, 37, 29, 45, 90, 3] without using temporary array
    class Tast1212
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 90, 45, 29, 37, 78 };
            for (int i = 0; i < arr.Length / 2; i++)
            {


                int temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;


            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }


        }

    }

    //WAP to merge 2 arrays to 3rd array. 3rd array should not have elements of same value
    class TaskDemo
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 2, 4 };
            int[] arr1 = { 3, 1, 5, 7, 8 };
            int[] arr2 = new int[arr.Length + arr1.Length];
            int index = 0;
            bool found = false;
            for (int i = 0; i < arr.Length; i++)
            {
               
                for (int j = 1; j < arr2.Length; j++)
                {
                    if (arr2[j] == arr[i])
                    {
                        found = true;
                    }
                }

                if (!found)
                {
                    arr2[index] = arr[i];
                    found = true;
                    index++;
                }
            }

            for (int i = 0; i < arr1.Length; i++)
            {
                found = false;
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr2[j] == arr1[i])
                    {
                        found = true;
                    }
                }

                if (!found)
                {
                    arr2[index] = arr1[i];
                    found = true;
                    index++;
                }
            }

            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(arr2[i]);
            }
        }
    }
    class SpecialChar
    { //Write a program to find total number of alphabets, digits or special character in a string
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String = ");
            string str = Console.ReadLine();
            int digit = 0, alphabets = 0, splchar = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] >= 65 && str[i] <= 90) || (str[i] >= 97 && str[i] <= 122))
                    alphabets++;
                else if (str[i] >= 48 && str[i] <= 57)
                    digit++;
                else
                    splchar++;
            }
            Console.WriteLine("Alpabets = " + alphabets);
            Console.WriteLine("Digits = " + digit);
            Console.WriteLine("Special Character = " + splchar);
        }
    }
    //WAP sort array elements in ascending order
    class AscendingOrder
    {
        static void Main(string[] args)
        {
            int s;
            Console.WriteLine("Enter size");
            s = int.Parse(Console.ReadLine());
            int[] arr = new int[s];
            Console.WriteLine("Enter Array Elements = ");
            for (int i = 0; i < s; i++)
                arr[i] = int.Parse(Console.ReadLine());
            int temp;
            for (int i = 0; i < s; ++i)
            {
                for (int j = i + 1; j < s; ++j)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("The Numbers in Ascending Order = ");
            for (int i = 0; i < s; i++)
                Console.WriteLine(arr[i]);
        }
    }
    // //WAP to replace all the 0’s with 1’s in your array. Your array is [26, 0, 67, 45, 0, 78, 54, 34, 10, 0, 34].
    class ReplaceNo
    {
        static void Main(string[] args)
        {
            int[] arr = { 26, 0, 67, 45, 0, 78, 54, 34, 10, 0, 34 };
            Console.WriteLine("Enter a Array Elements = ");

            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i] + " ");

            int no;
            Console.WriteLine("Enter any no = ");
            no = int.Parse(Console.ReadLine());

            int no1;
            Console.WriteLine("Enter any no to Replace = ");
            no1 = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == no)
                    arr[i] = no1;
            Console.WriteLine("Replacable array is = ");
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i] + " ");
            Console.ReadKey();

        }
    }
    class ArrayElementSquare
    {
        static void Main(string[] args)
        {

            int[] arr = { 12, 3, -19, 29, 5, -61, 44, 7, -9 };


            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i] + " ");


            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] = arr[i - 1] * arr[i - 1];
                }
            }
            Console.WriteLine("Modified Array is");
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i] + " ");

        }
    }
    class MinChar
    {
        static void Main(string[] args)
        {
            int s;
            char min;
            Console.WriteLine("Enter size = ");
            s = int.Parse(Console.ReadLine());
            char[] arr = new char[s];
            Console.WriteLine("Enter Characyer = ");
            for (int i = 0; i < s; i++)
            {
                arr[i] = Convert.ToChar(Console.ReadLine());
            }
            min = arr[0];
            for (int i = 1; i < s; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Minimun Character: " + min);

        }
    }
    class Unique
    {  //WAP to print all unique elements in the array
        static void Main(string[] args)
        {
            int s;
            int[] a = new int[10];
            Console.WriteLine("Enter size of array = ");
            s = int.Parse(Console.ReadLine());
            int[] arr = new int[s];
            Console.WriteLine("Enter Array elements=");
            for (int i = 0; i < s; i++)
                arr[i] = int.Parse(Console.ReadLine());
            for (int i = 0; i < s; i++)
            {
                int c = 1;
                if (arr[i] != -1)
                {
                    for (int j = i + 1; j < s; j++)

                    {
                        if (arr[i] == arr[j])
                        {
                            c++;
                            arr[j] = -1;
                        }
                    }
                    a[i] = c;
                }
            }
            Console.WriteLine("Unique elements in array are = ");
            for (int i = 0; i < s; i++)
            {
                if (arr[i] != -1)
                {
                    if (a[i] == 1)
                        Console.WriteLine(arr[i]);
                }
            }

        }

    }
    class Percentage
    {  //Write a Java program to enter marks of five subjects and calculate total, average and percentage.
        static void Main(string[] args)
        {
            double English, Phy, Chem, Maths, Comp, Total;
            double Percentage, Average;
            English = 65;
            Phy = 60;
            Chem = 60;
            Maths = 70;
            Comp = 77;
            Console.WriteLine("Marks of English=" + English);
            Console.WriteLine("Marks of Physics=" + Phy);
            Console.WriteLine("Marks of Chemistry=" + Chem);
            Console.WriteLine("Marks of Mathmatics=" + Maths);
            Console.WriteLine("Marks of Computer=" + Comp);

            Total = English + Phy + Chem + Maths + Comp;
            Average = Total / 5.0;
            Percentage = (Total / 500.0) * 100;

            Console.WriteLine("Total Marks =" + Total);
            Console.WriteLine("Average Marks=" + Average);
            Console.WriteLine("Percentage=" + Percentage);
        }
    }

    class Interest
    {//Write a Java program to enter P, T, R and calculate Simple Interest.
        static void Main(string[] args)
        {
            int P, T, R;
            double SI;
            P = 3400;
            T = 5;
            R = 5;
            Console.WriteLine(" Principal Amount=" + P);
            Console.WriteLine("Time=" + T);
            Console.WriteLine(" Rate=" + R);
            SI = (P * T * R) / 100;
            Console.WriteLine("Simple Interest is " + SI);
        }
    }

    class PerimeterofRectangle
    {  //Write a Java program to enter length and breadth of a rectangle and find its perimeter
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Length = ");
            int Length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a Breadth = ");
            int Breadth = int.Parse(Console.ReadLine());
            int Perimeter = 2 * (Length + Breadth);
            Console.WriteLine("Perimeter Of Rectangle=" + Perimeter);
        }
    }
}


