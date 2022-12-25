using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.AssignmentOnArray
{
    //WAP to search for a given number in an array and accordingly print the index if exists
    class SearchIndex
    {
        static void Main(string[] args)
        {
            int s;
            Console.WriteLine("Enter Size of Array Elements=");
            s = int.Parse(Console.ReadLine());
            int[] arr = new int[s];
            Console.WriteLine("Enter a Array Elements=");
            for (int i = 0; i < s; i++)
                arr[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Element to Search = ");
            int element = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < s; i++)
            {
                if (arr[i] == element)
                {
                    count = 1;
                    break;
                }
            }
            if (count == 1)
            {
                Console.WriteLine(+element + " is present at index");
            }
            else
            {
                Console.WriteLine(+element + "is not present at index");
            }
        }

    }
    //WAP to print all negative elements in an array and also count total number of negative elements in an array.
    class NegativeNo
    {   
        static void Main(string[] args)
        {
            int s;
            Console.WriteLine("Enter Size of Array Elements=");
            s = int.Parse(Console.ReadLine());
            int[] arr = new int[s];
            Console.WriteLine("Enter a Array Elements=");
            for (int i = 0; i < s; i++)
                arr[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("Negative Elements are = ");
            int count = 0;
            for (int i = 0; i < s; i++)
            {
                if (arr[i] < 0)
                {
                    Console.WriteLine(arr[i] + " ");
                    count++;
                }
            }
            Console.WriteLine("Total Negative elements are" + count);
        }
    }
    //WAP to put even and odd elements of array in two separate arrays
    class EvenOddSeparate
    {  
        static void Main(string[] args)
        {
            int s;
            Console.WriteLine("Enter Size of Array elements=");
            s = int.Parse(Console.ReadLine());
            int[] arr = new int[s];
            Console.WriteLine("Enter a Array Elements =");
            for (int i = 0; i < s; i++)
                arr[i] = int.Parse(Console.ReadLine());

            int[] even = new int[s];
            int[] odd = new int[s];
            int e, o;
            e = 0;
            o = 0;
            for (int i = 0; i < s; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even[e++] = arr[i];
                }
                else
                {
                    odd[o++] = arr[i];
                }
            }
            Console.WriteLine("Even array : ");
            for (int i = 0; i < e; i++)
            {
                Console.Write(even[i] + " ");
            }

            Console.WriteLine("\nOdd array : ");
            for (int i = 0; i < o; i++)
            {
                Console.Write(odd[i] + " ");
            }

        }
    }
    //WAP to find the maximum and minimum value in an array.
    class MaxMin
    {    
        static void Main(string[] args)
        {
            int s;
            Console.WriteLine("Enter a size of Array Elements=");
            s = int.Parse(Console.ReadLine());
            int[] arr = new int[s];
            Console.WriteLine("Enter a Array Element");
            for (int i = 0; i < s; i++)
                arr[i] = int.Parse(Console.ReadLine());

            int max = arr[0];
            int min = arr[0];
            for (int i = 1; i < s; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Maximum Element is  = " + max);
            Console.WriteLine("Minumun Element is = " + min);
        }
    }
    // WAP to find and count total number of duplicate elements in an array.
    class DuplicateElements
    {    
        static void Main(string[] args)
        {
            int s;
            Console.WriteLine("Enter Size of Array=");
            s = int.Parse(Console.ReadLine());
            int[] arr = new int[s];
            Console.WriteLine("Enter a Array Elements=");
            for (int i = 0; i < s; i++)
                arr[i] = int.Parse(Console.ReadLine());

            for (int i = 0; i < s; i++)
            {
                int count = 0;
                for (int j = 0; j < s; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine(+arr[i] + " occurs " + count + " Times ");
            }
        }
    }
    //WAP to print all unique elements in the array
    class Unique
    {  
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

    class Reverse
    { //WAP to reverse the array itself, don’t print array in reverse – I want current array reverse. Means e.g. arr[] = [3, 90, 45, 29, 37, 78] so your same array must be [78, 37, 29, 45, 90, 3] without using temporary array
        static void Main(string[] args)
        {
            int[] arr = { 3, 90, 45, 29, 37, 78 };
            Console.WriteLine("Array data is = ");

            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i] + " ");

            Console.WriteLine("Array in Reverse Order = ");
            for (int i = 5; i >= 0; i--)
                Console.WriteLine(arr[i] + " ");

        }
    }
    //WAP to replace all negative value with its immediate left elements square
    class NegativeNum
    {
        static void Main(string[] args)
        {
            int s;
            Console.WriteLine("Enter size of array = ");
            s = int.Parse(Console.ReadLine());
            int[] arr = new int[s];
            Console.WriteLine("Enter Array elements=");
            for (int i = 0; i < s; i++)
                arr[i] = int.Parse(Console.ReadLine());
            for (int i = 0; i < s; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] = arr[i - 1] * arr[i - 1];
                }
            }
            Console.WriteLine("Array is = ");
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i] + " ");
        }
    }
    //WAP to find the second smallest element in an array.
    class SecondSmallNo
    {  
        static void Main(string[] args)
        {
            int s;
            Console.WriteLine("Enter Array Size = ");
            s = int.Parse(Console.ReadLine());
            int[] arr = new int[s];
            Console.WriteLine("Enter Array elements = ");
            for (int i = 0; i < s; i++)
                arr[i] = int.Parse(Console.ReadLine());
            int temp = 0;
            for (int i = 0; i < s; i++)
            {
                for (int j = i + 1; j < s; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("Smallest Elements are = ");
            Console.WriteLine(arr[1]);
        }
    }

}
