using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrayMethod
{
    class ArrayMethod
    {
        static void Main(string[] args)
        {
            int[] list = { 34, 72, 13, 44, 25, 30, 10 };
            Console.WriteLine("Length of array is " + list.Length);

            int index = Array.IndexOf(list, 44);
            Console.WriteLine("Index of element 44 is " + index);

            int[] temp = list;
            int[] t = { 1, 0, 0, 0, 0, 0, 3 };
            Array.Copy(list, t, list.Length);
            Console.Write("Copied Array");

            Array.Copy(list, 2, t, 1, 5);
            foreach (int i in t)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("Original Array = ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Array.Reverse(temp);
            Console.Write("Reversed Array : ");

            foreach (int i in temp)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Array.Sort(list);
            Console.Write("Sorted Array : ");

            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Array.Clear(list, 3, 3);
            Console.Write("Cleared Array : ");

            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }

    }
}

