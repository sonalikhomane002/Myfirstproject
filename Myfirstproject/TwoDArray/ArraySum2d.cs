using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.TwoDArray
{
    class ArraySum2d
    {
        int[,] matrix = new int[3, 3];
        int[,] matrix1 = new int[3, 3];
        int[,] matrix2 = new int[3, 3];

        public void accept()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = int.Parse(Console.ReadLine());
        }
        public void display()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write(matrix[i, j] + " ");
                Console.WriteLine("");

            }
        }
        public void Add()
        {
            Console.WriteLine("enter the 1 matrix");
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                    matrix1[i, j] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The 1 st matrix is");
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                    Console.Write(matrix1[i, j] + " ");

                Console.WriteLine("");


            }
            Console.WriteLine("enter 2 matrix");
            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                    matrix2[i, j] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The 2 matrix is");
            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                    Console.Write(matrix2[i, j] + " ");

                Console.WriteLine("");
            }
            Console.WriteLine("Addition of 2 Matrix is");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = matrix1[i, j] + matrix2[i, j];
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write(matrix[i, j] + " ");

                Console.WriteLine("");

            }
        }
         static void Main(string[] args)
         {
                ArraySum2d obj = new ArraySum2d();
                //Console.WriteLine("Enter elements to 2D Array");
                obj.Add();

                //obj.display();

         }

    }

        
    
}
