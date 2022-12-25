using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPsdemo
{
    class ArrayTask
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 2, 8, 7, 1 };

            Console.WriteLine("Duplicate array element in given array");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.WriteLine(arr[j]);
                    }
                }
            }

        }
    }
    //Question1 Array element Average
    class ArrayElementAverage
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the Array element size");
            int s = int.Parse(Console.ReadLine());


            double[] arr = new double[s];
            double total = 0;
            Console.WriteLine("enter array element");
            for (int i = 0; i < s; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < arr.Length; i++)
            {
                total = total + arr[i];

            }
            double average = total / arr.Length;
            Console.WriteLine("the average is:=" + average);

        }

    }
    class Array4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the size");
            int s = int.Parse(Console.ReadLine());
            int[] arr = new int[s];
            Console.WriteLine("enter 5 element to arry");

            for (int i = 1; i < s; i++)
                arr[i] = int.Parse(Console.ReadLine());

            int no, cnt = 0;
            Console.WriteLine("enter any no to find");
            no = int.Parse(Console.ReadLine());


            int pos;
            Console.WriteLine("enter the position of no=");
            pos = int.Parse(Console.ReadLine());

            for (int i = 1; i <= s; i++)
                if (i > pos)
                    arr[i - 1] = arr[i];
                else
                    if (i == pos)
                    arr[i] = no;
                else
                    arr[i] = arr[i];
            Console.WriteLine("modified array is=");
            for (int i = 0; i < 5; i++)
                Console.WriteLine(arr[i] + "  ");

        }
    }
    class ArrayEvenOdd
    {
        static void Main(string[] args)
        {

            int s;
            Console.WriteLine("Enter size");
            s = int.Parse(Console.ReadLine());

            int[] ar = new int[s];
            Console.WriteLine("Enter array");
            for (int i = 0; i < s; i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }


            int[] even = new int[s];
            int[] odd = new int[s];
            int e, o;
            e = 0;
            o = 0;
            for (int i = 0; i < s; i++)
            {
                if (ar[i] % 2 == 0)
                {
                    even[e++] = ar[i];

                }
                else
                {
                    odd[o++] = ar[i];

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
    class ArrayElementTask
    {
        static void Main(string[] args)
        {
            int s;
            int sum = 0;
            Console.WriteLine("Enter size");
            s = int.Parse(Console.ReadLine());

            int[] ar = new int[s];
            Console.WriteLine("Enter array");
            for (int i = 0; i < s; i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }


            for (int j = 0; j < s; j += 2)
            {

                sum = sum + ar[j];


            }
            Console.WriteLine("aternate even no is" + sum);

        }
    }
    class ArrayInsertPos
    {
        static void Main(string[] args)
        {
            int s;
            Console.WriteLine("Enter size");
            s = int.Parse(Console.ReadLine());

            int[] ar = new int[s];
            Console.WriteLine("Enter array");
            for (int i = 0; i < s; i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }
            int pos, element;
            Console.WriteLine("Enter the position where the element  to be inserted=:");
            pos = int.Parse(Console.ReadLine());

            if (pos <= s && pos != 0)
            {
                Console.WriteLine("enter element to be inserted at position" + pos);
                element = int.Parse(Console.ReadLine());
                ar[pos - 1] = element;
                Console.WriteLine("Revised array is=:");
                for (int i = 0; i < s; i++)
                    Console.WriteLine(ar[i] + "  ");
            }
            else
                Console.WriteLine("Invalid position array index out of range");
            Console.ReadKey();

        }

    }
    class ArrayEleSearch
    {
        static void Main(string[] args)
        {
            int s;
            int sum = 0;
            Console.WriteLine("Enter size");
            s = int.Parse(Console.ReadLine());
            int[] arr = new int[s];
            Console.WriteLine("Enter array");
            for (int i = 0; i < s; i++)
                arr[i] = int.Parse(Console.ReadLine());

            int no, cnt = 0;
            Console.WriteLine("Enter any Number=");
            no = int.Parse(Console.ReadLine());

            int no1;
            Console.WriteLine("Enter any Number to replace=");
            no1 = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 4; i++)
                if (arr[i] == no)
                    arr[i] = no1;

            Console.WriteLine("Modified array is=");

            for (int i = 0; i < 5; i++)
                Console.WriteLine(arr[i] + " ");
            Console.ReadKey();

        }

    }
    class Array34
    {
        static void Main(string[] args)
        {
            int s;
            Console.WriteLine("Enter size");
            s = int.Parse(Console.ReadLine());

            int[] ar = new int[s];
            Console.WriteLine("Enter array");
            for (int i = 0; i < s; i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("enter array element no ");
            int no = int.Parse(Console.ReadLine());
            int cnt = 0;

            for (int i = 0; i < s; i++)
            {
                if (ar[i] == no)
                {
                    cnt++;
                }
            }
            Console.WriteLine(no + " is present" + cnt + "times in array");
            Console.ReadKey();

        }
    }
    class ArrayDigitFriquency
    {
        static void Main(string[] args)
        {
            int s;
            Console.WriteLine("Enter size");
            s = int.Parse(Console.ReadLine());

            int[] ar = new int[s];
            Console.WriteLine("Enter array");
            for (int i = 0; i < s; i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < s; i++)
            {
                int cnt = 0;
                for (int j = i; j < s; j++)
                {
                    if (ar[i] == ar[j])
                    {
                        cnt++;
                    }

                }
                Console.WriteLine(ar[i] + " is present" + cnt + "times in array");
            }
            Console.ReadKey();

        }
    }
    class ArrayPositiveNegative
    {
        static void Main(string[] args)
        {
            int s;
            Console.WriteLine("Enter size");
            s = int.Parse(Console.ReadLine());

            int[] ar = new int[s];
            Console.WriteLine("Enter array");
            for (int i = 0; i < s; i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }


            int[] pos = new int[s];
            int[] neg = new int[s];
            int p, n;
            p = 0;
            n = 0;
            for (int i = 0; i < s; i++)
            {
                if (ar[i] > 0)
                {
                    pos[p++] = ar[i];

                }
                else
                {
                    neg[n++] = ar[i];

                }
            }

            Console.WriteLine("Positve no array : ");
            for (int i = 0; i < p; i++)
            {
                Console.Write(pos[i] + " ");
            }

            Console.WriteLine("\nNegative no array : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(neg[i] + " ");
            }

        }

    }
    class MaxMinno
    {
        static void Main(string[] args)
        {
            int s;
            Console.WriteLine("enter the array size");
            s = int.Parse(Console.ReadLine());

            int[] ar = new int[s];
            Console.WriteLine("enter array");
            for (int i = 0; i < s; i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("the array is");
            for (int i = 0; i < s; i++)
            {
                Console.WriteLine(ar[i] + " ");
            }

            int Max = ar[0];
            int Min = ar[0];

            for (int i = 0; i < s; i++)
            {
                if (ar[0] > Max)
                {
                    Max = ar[i];
                }
                if (ar[i] < Min)
                {
                    Min = ar[i];
                }
            }

            Console.WriteLine("minimum element" + Max);
            Console.WriteLine("maximum element" + Min);

        }
    }
    class NegatveElecount
    {
        static void Main(string[] args)
        {
            int s;
            Console.WriteLine("Enter size");
            s = int.Parse(Console.ReadLine());

            int[] ar = new int[s];
            Console.WriteLine("Enter array");
            for (int i = 0; i < s; i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }



            int count = 0;
            for (int i = 0; i < s; i++)
            {
                if (ar[i] < 0)
                {
                    count++;

                }
            }
            Console.WriteLine("total negative no are:=" + count);
        }
    }
    class Occerance2
    {
        static void Main(string[] args)
        {
            int s;
            Console.WriteLine("Enter size");
            s = int.Parse(Console.ReadLine());

            int[] ar = new int[s];
            Console.WriteLine("Enter array");
            for (int i = 0; i < s; i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }

            Boolean[] found = new Boolean[s];
            for (int i = 0; i < s; i++)
            {
                found[i] = false;

            }
            for (int i = 0; i < s; i++)
            {
                if (found[i] == true)
                    continue;

                int cnt = 1;
                for (int j = i + 1; j < s; j++)
                {

                    if (ar[i] == ar[j])
                    {
                        found[j] = true;
                        cnt++;
                    }

                }
                Console.WriteLine(ar[i] + " present in " + cnt + " times");


            }
            Console.ReadKey();
        }
    }

    class ArrayPrimeno
    {
        static void Main(string[] args)
        {
            int s;
            Console.WriteLine("Enter size");
            s = int.Parse(Console.ReadLine());
            int[] ar = new int[s];
            Console.WriteLine("Enter array elements=");
            for (int i = 0; i < s; i++)
                ar[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("  prime numbers in the array are -");
            for (int i = 0; i < s; i++)
            {
                int count = 0;
                for (int j = 2; j <= ar[i] / 2; j++)
                {
                    if (ar[i] % j == 0)
                    {
                        count = 1;
                        break;
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine(ar[i]);
                }


            }
        }
    }
    class Chararray
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter size");
            int s = int.Parse(Console.ReadLine());
            char[] ar = new char[s];
            Console.WriteLine("Enter array char  elements=");
            for (int i = 1; i < s; i++)
            {


                ar[i] = Convert.ToChar(Console.ReadLine());


            }
            Console.WriteLine("array element is");
            for (int i = 1; i < s; i++)
            {
                Console.WriteLine(ar[i]);
            }




        }
    }
    class SearchElemntIndex
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size");
            int s = int.Parse(Console.ReadLine());

            int[] ar = new int[s];
            Console.WriteLine("Enter array");
            for (int i = 0; i < s; i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter element of an array");
            int ele = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < s; i++)
            {
                if (ar[i] == ele)
                {
                    Console.WriteLine($"{ele} is present at index {i}");
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine($"{ele} is not present in an array");
            }

        }
    }
    class SearchChar
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter size");
            int s = int.Parse(Console.ReadLine());
            char[] ar = new char[s];
            Console.WriteLine("Enter the char  elements=");
            for (int i = 0; i < s; i++)
            {
                ar[i] = Convert.ToChar(Console.ReadLine());
            }


            Console.WriteLine("Enter the char element to be Search");
            bool ispresent = false;
            char ch1 = Convert.ToChar(Console.ReadLine());
            for (int i = 0; i <= s; i++)
            {
                if (ar[i] == ch1)
                {
                    ispresent = true;
                    Console.WriteLine("element is present " + ch1);
                    break;
                }
            }

            if (ispresent == false)
                Console.WriteLine("Element is not present");


        }
    }
    class UpperToLowerchar
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter the Size");
            int s = int.Parse(Console.ReadLine());

            char[] arr = new char[s];
            Console.WriteLine("enter char element");
            for (int i = 0; i < s; i++)
            {
                arr[i] = Convert.ToChar(Console.ReadLine());
            }


            for (int i = 0; i < s; i++)
            {
                if (arr[i] >= 65 && arr[i] <= 90)
                {
                    Console.WriteLine(arr[i]);

                }


            }

        }
    }
    class ComparisionInArray
    {
        static void Main(string[] args)
        {
            int s;
            Console.WriteLine("Enter size");
            s = int.Parse(Console.ReadLine());

            int[] arr1 = new int[s];
            Console.WriteLine("Enter array elements=");
            for (int i = 0; i < s; i++)
                arr1[i] = int.Parse(Console.ReadLine());

            int[] arr2 = new int[s];
            Console.WriteLine("Enter element for 2nd Array=");
            for (int i = 0; i < s; i++)
                arr2[i] = int.Parse(Console.ReadLine());

            bool ispresent = false;
            for (int i = 0; i < s; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    ispresent = true;
                    break;
                }

            }
            if (ispresent)
            {
                Console.WriteLine("Both Array are same");
            }
            else
            {
                Console.WriteLine("Both Array are not same");
            }
        }
    }
    class ArrayCompare
    {
        static void Main(string[] args)
        {


            Boolean isArrayEqual = true;

            int[] arr1 = { 1, 2, 3, 4, 4, 5 };
            int[] arr2 = { 1, 2, 3, 4, 4, 6 };

            if (arr1.Length == arr2.Length)
            {
                for (int i = 0; i < arr2.Length; i++)
                {
                    if (arr2[i] != arr1[i])
                    {
                        isArrayEqual = false;
                        break;
                    }
                }
            }

            if (isArrayEqual)
            {
                Console.WriteLine("Both arrays are equal");
            }
            else
            {
                Console.WriteLine("Both arrays are not equals");
            }

        }
    }
    class MergeArray
    {
        static void Main(string[] args)
        {
            int i, j;
            Console.WriteLine("Enter array 1 size:");
            int size = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter array 1 elements:");
            int[] arr1 = new int[size];
            for (i = 0; i < size; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter array 2 size:");
            int size2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter array 2 elements:");
            int[] arr2 = new int[size2];
            for (i = 0; i < size2; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }

            int[] arr3 = new int[size + size2];
            for (i = 0, j = 0; i < size; i++)
            {
                arr3[j++] = arr1[i];
            }
            for (i = 0; i < size2; i++)
            {
                arr3[j++] = arr2[i];
            }

            Console.WriteLine("Elements of array 3 are:");
            for (i = 0; i < size + size2; i++)
            {
                Console.Write(arr3[i] + " ");
            }
        }


    }
    class ArrayCombination
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[10];
            int[] arr2 = new int[5];
            int i;
            Console.WriteLine("Enter 5 Elements in array=");
            for (i = 0; i < 5; i++)
                arr1[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 5 Elements in 2nd array=");
            for (i = 0; i < 5; i++)
                arr2[i] = int.Parse(Console.ReadLine());

            i = 5;
            for (int j = 0; j < 5; j++, i++)
                arr1[i] = arr2[j];

            Console.WriteLine("Concatinated array is =");
            for (i = 0; i < arr1.Length; i++)
                Console.Write(arr1[i] + " ");

        }
    }
    class ReverseArray
    {
        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("enter the array size");
            size = int.Parse(Console.ReadLine());

            int[] ar = new int[size];
            Console.WriteLine("enter array element");

            for (int i = 0; i < size; i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0, t, j = size - 1; i < size / 2; i++, j--)
            {
                t = ar[i];
                ar[i] = ar[j];
                ar[j] = t;

            }
            Console.WriteLine("Reverse Array is:=");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(ar[i] + "  ");
            }

        }


    }
    class AlternateMergeArray
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[5];
            int[] arr2 = new int[5];

            int[] arr3 = new int[arr1.Length + arr2.Length];

            int i, j;
            Console.WriteLine("enter 5 element");
            for (i = 0; i < 5; i++)
                arr1[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("enter 5 element");
            for (i = 0; i < 5; i++)
                arr2[i] = int.Parse(Console.ReadLine());

            for (i = j = 0; i < 5; i++)
            {
                arr3[j++] = arr1[i];
                arr3[j++] = arr2[i];

            }
            Console.WriteLine("Alternate element of both array");
            for (i = 0; i < arr3.Length; i++)
                Console.WriteLine(arr3[i] + " ");





        }
    }
    class DuplicateArray
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[5];
            int[] arr2 = new int[5];

            int[] arr3 = new int[arr1.Length + arr2.Length];

            int i;
            Console.WriteLine("enter 5 element");
            for (i = 0; i < 5; i++)
                arr1[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("enter 5 element");
            for (i = 0; i < 5; i++)
                arr2[i] = int.Parse(Console.ReadLine());

            int k = 0, cnt;
            for (i = 0; i < arr1.Length; i++)
            {
                cnt = 0;
                for (int j = k - 1; j >= 0; j--)
                {
                    if (arr3[j] == arr1[i])
                    {
                        cnt++;
                        break;
                    }
                }
                if (cnt == 0)
                {
                    arr3[k] = arr1[i];
                    k++;

                }

            }
            for (i = 0; i < arr2.Length; i++)
            {
                cnt = 0;
                for (int j = k - 1; j >= 0; j--)
                {
                    if (arr3[j] == arr2[i])
                    {
                        cnt++;
                        break;
                    }
                }
                if (cnt == 0)
                {
                    arr3[k] = arr2[i];
                    k++;
                }
            }
            Console.WriteLine("concatinated array");
            for (i = 0; i < k; i++)
                Console.WriteLine(arr3[i] + " ");
        }
    }
    class SortArray
    {
        static void Main(string[] args)
        {
            int size, t;
            Console.WriteLine("enter size of array");
            size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];

            Console.WriteLine("enter element");
            for (int i = 0; i < size; i++)
                arr[i] = int.Parse(Console.ReadLine());

            for (int i = 0; i < size - 1; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        t = arr[i];
                        arr[i] = arr[j];
                        arr[j] = t;
                    }
                }
            }
            Console.WriteLine("Sorted Array is=");
            for (int i = 0; i < size; i++)
                Console.Write(arr[i] + "  ");
        }
    }
    class CharArray
    {
        static void Main(string[] args)
        {
            char[] str = new char[] { 'A', 'b', 'd', 'v' };

            Console.WriteLine("Data is");
            for (int i = 0; i < str.Length; i++)
                Console.WriteLine(str[i]);

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 65 && str[i] <= 90)
                    str[i] = (char)(str[i] + 32);
                else
                    str[i] = (char)(str[i] - 32);

            }
            Console.WriteLine("converted data is=");
            for (int i = 0; i < str.Length; i++)
                Console.WriteLine(str[i]);
        }
    }


    class CharOccurance
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter size");
            int s = int.Parse(Console.ReadLine());
            char[] ar = new char[s];
            Console.WriteLine("Enter the char  elements=");
            for (int i = 0; i < s; i++)
            {
                ar[i] = Convert.ToChar(Console.ReadLine());
            }


            Console.WriteLine("Enter the char element to be Search");
            bool isFound = false;
            char ch1 = Convert.ToChar(Console.ReadLine());
            for (int i = 0; i <= s; i++)
            {
                if (ar[i] == ch1)
                {
                    isFound = true;

                    break;
                }
            }

            if (isFound)
                Console.WriteLine("Char is present " + ch1);
            else
                Console.WriteLine("Char is not present");

        }


    }
    class OccranceCh
    {
        static void Main(string[] args)
        {
            char[] str = new char[] { 'd', 'S', 'f', 'A', 'A' };
            Console.WriteLine("data is");
            for (int i = 0; i < str.Length; i++)
                Console.WriteLine(str[i]);

            Console.WriteLine("enter any char=");
            char ch = char.Parse(Console.ReadLine());
            bool found = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ch)
                {
                    found = true;
                    break;
                }
            }
            if (found)
                Console.WriteLine("Present");
            else
                Console.WriteLine("Absent");

        }
    }
    class Descending
    {
        static void Main(string[] args)
        {
            int size, t;
            Console.WriteLine("enter size of array");
            size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];

            Console.WriteLine("enter element");
            for (int i = 0; i < size; i++)
                arr[i] = int.Parse(Console.ReadLine());

            for (int i = 0; i < size - 1; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        t = arr[i];
                        arr[i] = arr[j];
                        arr[j] = t;
                    }
                }
            }
            Console.WriteLine("Sorted Array is=");
            for (int i = 0; i < size; i++)
                Console.Write(arr[i] + "  ");

        }
    }
    class ArrayElementSquare
    {
        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("enter size of array");
            size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];

            Console.WriteLine("enter element");
            for (int i = 0; i < size; i++)
                arr[i] = int.Parse(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] = arr[i - 1] * arr[i - 1];
                }
            }
            Console.WriteLine("Array is");
            for (int i = 0; i < size; i++)
                Console.WriteLine(arr[i] + " ");

        }
    }
    class AscendingDescendingChar
    {
        static void Main(string[] args)
        {
            char t;


            char[] str = new char[] { 'd', 'c', 'a', 'b', 'e', 'z', 'y', 'x', 's', 't' };
            Console.WriteLine("data is");
            for (int i = 0; i < str.Length; i++)
                Console.WriteLine(str[i]);

            for (int i = 0; i < str.Length; i++)
            {

                for (int j = i + 1; j < str.Length; j++)
                {
                    if (i < str.Length / 2)
                    {
                        if (str[i] > str[j])
                        {
                            t = str[i];
                            str[i] = str[j];
                            str[j] = t;
                        }
                    }
                    else
                    {
                        if (str[i] < str[j])
                        {
                            t = str[i];
                            str[i] = str[j];
                            str[j] = t;
                        }
                    }
                }
            }
            Console.WriteLine("Sorted Array is=");
            for (int i = 0; i < str.Length; i++)
                Console.Write(str[i] + "  ");


        }
    }
    class ArrayInbuildMethod
    {
        static void Main(string[] args)
        {
            int[] list = { 34, 56, 78, 23, 56, 67, 34 };
            Console.WriteLine("length of array is" + list.Length);


            int[] temp = list;


            int[] t = new int[list.Length];

            Array.Copy(list, t, list.Length);
            Console.WriteLine("copied array");

            foreach (int i in t)
            {
                Console.WriteLine(i + " ");
            }

        }
    }
    class AlterMerge
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] arr2 = { 11, 22, 33, 44 };

            int[] arr3 = new int[arr1.Length + arr2.Length];
            int k = 0;
            for (int i = 0; i < arr1.Length; i++)
            {

                arr3[k] = arr1[i];
                if (k < (arr2.Length * 2))
                    k = k + 2;
                else
                    k = k + 1;
            }
            k = 1;
            for (int i = 0; i < arr2.Length; i++)
            {
                arr3[k] = arr2[i];
                k = k + 2;
            }
            Console.WriteLine("Alternate element of both array");
            for (int i = 0; i < arr3.Length; i++)
                Console.WriteLine(arr3[i] + " ");


        }
    }


    class ArraySwapMethod
    {
        static void Main(string[] args)
        {
            int[] list = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // Console.WriteLine("length of array is" + list.Length);


            int temp = list[0];
            list[0] = list[9];
            list[9] = temp;

            temp = list[1];
            list[1] = list[8];
            list[8] = temp;

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }


    class ArrayAlterPositiveNegative
    {
        static void Main(string[] args)
        {
            int[] list = { 1, 2, 3, -4, -1, 4 };
            // Console.WriteLine("length of array is" + list.Length);
            int[] arr2 = new int[list.Length];

            int positiveCount = 0, negativeCount = 0;

            int[] positiveArr = new int[list.Length];
            int[] negativeArr = new int[list.Length];
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] < 0)
                {
                    negativeArr[negativeCount] = list[i];
                        negativeCount++;
                }
                else
                {
                    positiveArr[positiveCount] = list[i];
                    positiveCount++;
                }
            }
            int k = 1;
            for (int i = 0; i < positiveCount; i++)
            {

                arr2[k] = positiveArr[i];
                if (k < (negativeCount * 2)-1)
                    k = k + 2;
                else
                    k = k + 1;
            }
            k = 0;
            for (int i = 0; i < negativeCount; i++)
            {
                arr2[k] = negativeArr[i];
                k = k + 2;
            }
            
            Console.WriteLine("Alternate element of both array");
            for (int i = 0; i < arr2.Length; i++)
                Console.WriteLine(arr2[i] + " ");
        }
    }
    class ArrayZeroNonzero
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 0, 7, 0, 8, 0, 3 };
            int[] arr2 = new int[arr.Length];

            int Count = 0;
            for(int i=0;i<arr.Length;i++)
            {
               if(arr[i]==0)
                {
                    Count++;
                }
            }
            int k = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    arr2[k] = arr[i];
                    k++;
                }
            }

            for (int i = arr.Length - Count; i < arr2.Length; i++)
            {

                if (i > arr.Length - Count)
                {
                    arr2[i] = 0;
                }
            }
            
            for(int i=0;i<arr2.Length;i++)
            {
                Console.WriteLine(arr2[i]+" ");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = 0;
            for (int i = 2; i <= 20; i++)
            {
                bool isprime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isprime = false;
                        break;
                    }
                    cnt++;
                }

                if (isprime == true)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }


}





