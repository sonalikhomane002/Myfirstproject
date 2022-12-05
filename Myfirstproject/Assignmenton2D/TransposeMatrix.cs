using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Assignmenton2D
{
    class TransposeMatrix
    {
        int[,] arr = new int[3, 3];
        int[,] arr1 = new int[3, 3];


        public void accept()
        {
            Console.WriteLine("Enter the array Element");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    arr[i, j] = int.Parse(Console.ReadLine());
            }
        }
        public void display()
        {
            Console.WriteLine("Array element ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    Console.Write(arr[i, j] + " ");
                Console.WriteLine("");

            }
        }


        public void Transpose()
        {
            Console.WriteLine("Transepose of array");
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                    arr1[j, i] = arr[i, j];
            }
            for (int j = 0; j< arr.GetLength(1); j++)
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                    Console.Write(arr[j, i] + " ");
                Console.WriteLine("");


            }
        }
         static void Main(string[] args)
         {
                TransposeMatrix obj = new TransposeMatrix();
                obj.accept();
                obj.display();
                obj.Transpose();
               
              

         }


    }
}


