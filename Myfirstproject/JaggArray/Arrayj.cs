using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.JaggArray
{
    class Arrayj
    {
        static void Main(string[] args)
        {
            int[][] jaggedArr = new int[3][];
            jaggedArr[0] = new int[] { 1, 2, 3,4};
            jaggedArr[1] = new int[] {5,6};
            jaggedArr[2] = new int[] { 7,8, 9};

            Console.WriteLine();

            for(int i=0;i<jaggedArr.GetLength(0);i++)
            {
                for(int j=0;j<jaggedArr[i].Length;j++)
                    Console.Write(jaggedArr[i][j]+" ");
                Console.WriteLine("");
            }
            
        }

    }
}
