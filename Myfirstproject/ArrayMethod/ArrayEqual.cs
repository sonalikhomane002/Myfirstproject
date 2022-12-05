using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrayMethod
{
    class ArrayEqual
    {
        static void Main(string[] args)
        {
            int[] a1 = { 1, 2, 3, 4, 5 };
            int[] a2 = a1;

            if (Array.Equals(a1, a2))
                Console.WriteLine("Arrays are equal");
            else
                Console.WriteLine("array not equal");
            Console.ReadKey();


        }



    }
}

