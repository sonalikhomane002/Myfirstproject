using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Assignmenton2D
{
    //Accept data in 2D array
    class DataAccept
    {
        int[,] matrix = new int[3, 4];

        public void Accept()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        public void Display()
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
            DataAccept obj = new DataAccept();
            Console.WriteLine("enter the element in matrix");
            obj.Accept();
            Console.WriteLine("Matrix is");
            obj.Display();
        }

    }

}
