using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.TwoDArray
{
    class My2DArr
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
        static void Main(string[] args)
        {
            My2DArr obj = new My2DArr();
            Console.WriteLine("Enter elements to 2D Array");
            obj.accept();
            Console.WriteLine("Matrix of Array");
            obj.display();


        }
    }
}
