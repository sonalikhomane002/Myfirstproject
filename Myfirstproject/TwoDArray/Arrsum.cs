using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.TwoDArray
{
    class Arrsum
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
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    sum = sum + matrix[i, j];


                Console.WriteLine("Addition of" +i+"row"+sum);
            }
        }
        public void ColumnWiseSum()
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum = sum + matrix[j, i];


                    Console.WriteLine("Addition of" + j + "Column" + sum);
                }

            }
        }
        static void Main(string[] args)
        {
            Arrsum obj = new Arrsum();
            Console.WriteLine("Enter elements to 2D Array");
            obj.accept();
            Console.WriteLine("Matrix of Array");
            obj.display();
            obj.rowWiseSum();
            obj.ColumnWiseSum();



        }
    }
}
