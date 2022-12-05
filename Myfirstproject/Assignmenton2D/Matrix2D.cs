using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Assignmenton2D
{
    //sum of main diagonal element of matrix
    class Matrix2D
    {
        int[,] matrix = new int[3, 3];
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
        public int sumOfDiagonal()
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                        sum += matrix[i, j];
                }

            }
            return sum;
        }
        public static void Main(string[] args)
        {
            Matrix2D obj = new Matrix2D();
            Console.WriteLine("Enter elements to 2D Array");
            obj.accept();
            Console.WriteLine("Matrix of Array");
            obj.display();
            Console.WriteLine("sum of Diagonal element" + obj.sumOfDiagonal());
        }
    }
}
