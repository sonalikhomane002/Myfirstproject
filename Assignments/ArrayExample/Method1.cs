using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayMethod.ArrayExample
{
    class Method1
    {
        static void Main(string[] args)
        {
            int[] list = { 34, 76, 12, 56, 78, 34, 45, 45 };
            Console.WriteLine("Array length is" + list.Length);

            int[] temp = list;
            Console.WriteLine("Original Array is=:");

            foreach (int i in list)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine();

            Array.Reverse(temp);
            Console.WriteLine("Reversed array is=");
            foreach (int i in temp)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine();
        }
    }
}
