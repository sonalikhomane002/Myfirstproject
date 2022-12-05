using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.TwoDArray
{
    class ArrayDiagonal
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
        public int sumOfAntiDiagonal()
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if ((i + j) == matrix.GetLength(0) - 1)
                        sum += matrix[i, j];
                }

            }
            return sum;

            
        }
        static void Main(string[] args)
        {
            ArrayDiagonal obj = new ArrayDiagonal();
            Console.WriteLine("Enter elements to 2D Array");
            obj.accept();
            Console.WriteLine("Matrix of Array");
            obj.display();
            Console.WriteLine("sum of Diagonal element"+obj.sumOfDiagonal());
            Console.WriteLine("sum of AntiDiagonal element" + obj.sumOfAntiDiagonal());





        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 99, 95, 93, 89, 87 };
            int i, max, min, n;
            // size of the array
            n = 5;
            max = arr[0];
            min = arr[0];
            for (i = 1; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.Write("Maximum element = {0}", max);


            Console.Write("Minimum element = {0}", min);



        }
    }
    

}
