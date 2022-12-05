using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Task
{
    class Task1
    {
        static void Main(string[] args)
        {
            int[] arr = { 23,25,67,86,66,66 };
            int s = arr.Length;

            for(int i=0;i<s;i+=2)
            {

                Console.WriteLine(arr[i]);
               // i++; 
            }
        }
    }
}
