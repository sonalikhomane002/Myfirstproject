using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Array1D
{
    class Program1
    {
        static void Main(string[] args)
        {

            int[] arr = { 10, 20, 30, 40, 50 };
            //Console.WriteLine("Array data is=");
            // for(int i=0;i<5;i++)
            // {
            //  Console.Write(arr[i]+" ");
            //}
            Console.WriteLine("Array is in Reverse order=");
            for (int i = 4; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
    class Program2
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int[] arr1 = new int[5];
            Console.WriteLine("enter 5 element");
            for (int i = 0; i < 5; i++)
                arr[i] = int.Parse(Console.ReadLine());

            for (int i = 0, j = 4; i <= 4; i++, j--)
                arr1[i] = arr[j];

            Console.WriteLine("copied array is=");
            for (int i = 0; i < 5; i++)
                Console.WriteLine(arr1[i] + " ");
        }
    }
    class Program3
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int[] arr1 = new int[5];
            Console.WriteLine("enter 5 element");
            for (int i = 0; i < 5; i++)
                arr[i] = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 4; i++)
                arr1[i] = arr[i];

            Console.WriteLine("copied array is=");
            for (int i = 0; i < 5; i++)
                Console.WriteLine(arr1[i] + " ");
        }
    }
    class Program4
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("enter 5 element to arry");

            for (int i = 0; i < 5; i++)
                arr[i] = int.Parse(Console.ReadLine());

            int no, cnt = 0;
            Console.WriteLine("enter any no to find");
            no = int.Parse(Console.ReadLine());


            int no1;
            Console.WriteLine("enter any no to replace=");
            no1 = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 4; i++)
                if (arr[i] == no)
                    arr[i] = 0;
            Console.WriteLine("modified array is=");
            for (int i = 0; i < 5; i++)
                Console.WriteLine(arr[i] + "  ");
        }
    }
    class Program5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the size");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];
            Console.WriteLine("enter array element=");
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("array is=");
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(arr[i] + " ");
                sum = sum + arr[i];
            }
            Console.WriteLine("\nAddition is=" + sum);
        }
    }
    class Program6
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                Console.WriteLine("enter the size");
                int s = int.Parse(Console.ReadLine());

                int[] arr = new int[s];
                Console.WriteLine("enter the array element");
                for (int i = 0; i < s; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Array is=");
                int sum = 0;
                for (int i = 0; i < s; i++)
                {

                    Console.WriteLine(arr[i] + " ");
                    if (arr[i] % 2 == 0)
                    {
                        sum = sum + arr[i];
                    }
                }
                Console.WriteLine("\nEven no addition is=" + sum);
            }
        }
    }
    class Program7
    {
        //Q1 Even and Odd Element count in Array
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

            int Even_count = 0;
            int Odd_count = 0;

            for (int i = 0; i < s; i++)
            {
                if (ar[i] % 2 == 0)
                {
                    Even_count++;

                }
                else
                {
                    Odd_count++;
                }

            }
            Console.WriteLine("Number of Even Element=" + Even_count);
            Console.WriteLine("Number of Odd Element =" + Odd_count);

        }
    }
    class Test
    {
        //Que2 Predict the output

        static int mcCartyCounter = 100;
        public static int mcCarthy(int n)
        {
            mcCartyCounter++;
            if (n > 100)
                return n - 10;
            else
                return mcCarthy(n + 11);
        }
        public static void Main(String[] arg)
        {
            Console.WriteLine(mcCarthy(100) + "  " + mcCartyCounter);
        }


    }
    class Program8
    {
        //minimum frequency char from an array
        static void Main(string[] args)
        {
            char[] arr = { 'a', 'b', 'c', 'c', 'b' };


            int[] freq = new int[arr.Length];
            char minChar = arr[0];

            int i, j, min;
            for (i = 0; i < arr.Length; i++)
            {
                freq[i] = 1;
                for (j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j] && arr[i] != ' ' && arr[i] != '0')
                    {
                        freq[i]++;


                        arr[j] = '0';
                    }
                }
            }


            min = freq[0];
            for (i = 0; i < freq.Length; i++)
            {

                if (min > freq[i] && freq[i] != '0')
                {
                    min = freq[i];
                    minChar = arr[i];
                }
            }

            Console.WriteLine(minChar);

        }
    }
    class Nib
    {
        //set and get
        private string materialtype;
        private float width;

        public string Materialtype
        {
            get { return materialtype; }
            set { materialtype = value; }
        }
        public float Width
        {
            get { return width; }
            set { width = value; }
        }
    }
    class Refil
    {
        private string inkcolor;
        private float length;
        private Nib _nib;


        public string Inkcolor
        {
            get { return inkcolor; }
            set { inkcolor = value; }

        }
        public float Length
        {
            get { return length; }
            set { length = value; }
        }
        public Nib nib
        {
            get { return _nib; }
            set { _nib = value; }
        }

    }
    class Pen
    {
        private float capLength;
        private string brand;
        private Refil _refil;

        public float CapLength
        {
            get { return capLength; }
            set { capLength = value; }
        }
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public Refil refil
        {
            get { return _refil; }
            set { _refil = value; }

        }

    }
    class Client
    {
        static void Main(string[] args)
        {
            Pen p1 = new Pen();
            p1.CapLength = 2.1f;
            p1.Brand = "Cello";
            Refil r1 = new Refil();
            r1.Inkcolor = "Blue";
            r1.Length = 2.5f;
            Nib n1 = new Nib();
            n1.Materialtype = "steel";
            n1.Width = 2.4f;
            r1.nib = n1;
            p1.refil = r1;

            Console.WriteLine("CapLength=" + p1.CapLength + "\nBrand="
                + p1.Brand + "\nInkcolor=" + p1.refil.Inkcolor + "\nLength="
                + p1.refil.Length + "\nMaterial type=" + p1.refil.nib.Materialtype + "\nWidth="
                + p1.refil.nib.Width);
        }
    }
    class program9
    {
        //seperate zero from non zero in integer array
        static void Main(string[] args)
        {
            int[] arr = { 12, 0, 7, 0, 8, 0, 3 };
            int[] arr2 = new int[arr.Length];

            int Count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
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

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }
        }
    }
    class DuplicateNo
    {
        //Remove duplicate array element in array
        static void Main(string[] args)
        {
            int[] arr = { 4, 3, 2, 4, 9, 2 };
            Console.WriteLine("Array data is:");

            for (int i = 0; i < 6; i++)
                Console.WriteLine(arr[i] + " ");
            int k = 0, cnt;
            for (int i = 0; i < arr.Length; i++)
            {
                cnt = 0;
                for (int j = k - 1; j >= 0; j--)
                {
                    if (arr[j] == arr[i])
                    {
                        cnt++;
                        break;
                    }
                }
                if (cnt == 0)
                {
                    arr[k] = arr[i];
                    k++;
                }
            }
            Console.WriteLine("Concatinated array is=");
            for (int i = 0; i < k; i++)
                Console.Write(arr[i] + " ");
        }
    }
    class Numbers
    {
        //predict the output
        public static void Main(String[] args)
        {
            int[] var = new int[10];
            for (int i = 0; i < 10; ++i)
            {
                var[i] = i;
                Console.WriteLine(var[i] + " ");
                i++;
            }
        }
    }
    class PerfectSquareNo
    {
        //display all perfect square no in array
        static void Main(string[] args)
        {
            int[] arr = { 23, 43, 25, 49, 12, 9, 78, 66, 39, 0 };
            int n = arr.Length;

            for (int i = 0; i < n; i++)
            {
                for (int j = 2; j < arr[i] / 2; j++)
                {
                    int div = arr[i] / j;
                    if (arr[i] % j == 0 && div == j)
                    {
                        Console.WriteLine(arr[i]);
                        break;
                    }
                }
            }
        }


    }
    public class ArrayOuput
    {
        //predict the output
        public static void Main(String[] args)
        {
            //int[] a1, a2;
            int[] a1 = { 1, 2, 3 };
            string[] a2 = new String[a1.Length];
            for (int i = 0; i < a1.Length; i++)
            {
                a2[i] = a1[i].ToString();
            }
            for (int i = 0; i < a2.Length; i++)
            {

                Console.WriteLine(a2[i]);
            }

        }



    }
    class SeperateZero
    {
        //seperate zero and non zero in integer array
        static void Main(string[] args)
        {
            int[] arr = { 12, 0, 7, 0, 8, 0, 3 };
            Console.WriteLine("Input Array :");

            for (int i = 0; i < 7; i++)
                Console.WriteLine(arr[i] + " ");

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int count = 0;

                    for (i = 0; i < arr.Length; i++)
                        if (arr[i] != 0)
                            arr[count++] = arr[i];

                    while (count < arr.Length)
                        arr[count++] = 0;
                }
            }
            Console.WriteLine("Input Array After moving zeros to end :=");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + "  ");
        }


    }
    class Replace
    {  //WAP to replace all the 0’s with 1’s in your array. 
        static void Main(String[] args)
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
    class Buzz
    {
        static void Main(string[] args)
        {

            int count1 = 0, count2 = 0, count3 = 0;
            for (int i = 1; i <= 50; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Buzzfizz");
                    count1++;
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Buzz");
                    count2++;
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Fizz");
                    count3++;
                }
            }
            Console.WriteLine("Count of BuzzFizz : " + count1);
            Console.WriteLine("Count of Buzz : " + count2);
            Console.WriteLine("Count of Fizz : " + count3);
        }
    }



}




