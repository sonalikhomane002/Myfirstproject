using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Assignmenton2D
{
    //Sum of row and column in 2D matrix
    class SumOfRowCol
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
        public void rowWiseSum()
        {
            int sum;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
                Console.WriteLine("Addition of " + i + " row is " + sum);
            }
        }
        public void colWiseSum()
        {
            int sum;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum = sum + matrix[j, i];
                }
                Console.WriteLine("Addition of " + i + " column is " + sum);
            }
        }
        public static void Main(string[] args)
        {
            SumOfRowCol obj = new SumOfRowCol();
            Console.WriteLine("Enter elements to 2D Array");
            obj.accept();
            Console.WriteLine("Matrix of Array");
            obj.display();
            Console.WriteLine("RowWise sum");
            obj.rowWiseSum();
            Console.WriteLine("ColumnWise sum");
            obj.colWiseSum();
        }
    }
}
