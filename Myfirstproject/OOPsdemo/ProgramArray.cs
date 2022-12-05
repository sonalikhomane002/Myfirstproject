using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPsdemo
{
    class ProgramArray
    {
        static void Main(string[] args)
        {
            int[] arr =new int[5];
            Console.WriteLine("enter the 5 elements=:");
            //int arr = int.Parse(Console.ReadLine());   
            for (int i = 0; i < 5; i++)
            {
                // Console.WriteLine("Array data is=");
                arr[i] = int.Parse(Console.ReadLine());

            }
            /*arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            arr[3] = 4;
            arr[4] = 5;
           */
            Console.WriteLine("Array element is =");
            for (int i=0;i<5;i++)
            {
              Console.Write(arr[i]+" ");
            }
        }
    }
}
