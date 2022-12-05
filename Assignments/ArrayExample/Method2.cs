using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayMethod.ArrayExample
{
    class Method2
    {
        static void Main(string[] args)
        {

            int[] list = { 34, 56, 78, 23, 56, 67, 34 };
            Console.WriteLine("length of array is" + list.Length);


            int[] temp = list;


            int[] t = new int[7];

            Array.Copy(list, t, 5);
            Console.WriteLine("copied array");

            foreach (int i in t)
            {
                Console.WriteLine(i + " ");
            }
        }
    }
}
