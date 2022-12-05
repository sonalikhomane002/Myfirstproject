using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.JaggArray
{
    class Pattern
    {
         int[,] matrix = new int[4, 4];
        public void Accept()
        {
            Console.WriteLine("Enter Matrix := ");
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = int.Parse(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine("Matrix is := ");
            Console.WriteLine();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }
        public void ExternallArray()
        {
            Console.WriteLine("Matrix is := ");
            Console.WriteLine();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j == 0 || j == 3 || i == 0 || i == 3)
                        Console.Write(matrix[i, j] + "  ");
                    else
                        Console.Write("   ");

                }
                Console.WriteLine();
            }
        }
        public void NPatternArray()
        {
            Console.WriteLine("Matrix is := ");
            Console.WriteLine();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j || j == 0 || j == 3)
                        Console.Write(matrix[i, j] + "  ");
                    else
                        Console.Write("   ");

                }
                Console.WriteLine();
            }
        }
        public void ZPatternArray()
        {
            Console.WriteLine("Matrix is := ");
            Console.WriteLine();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if ((i + j) == matrix.GetLength(0) - 1 || i == 0 || i == 3)
                        Console.Write(matrix[i, j] + "  ");
                    else
                        Console.Write("   ");

                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Pattern obj = new Pattern();
            obj.Accept();
            obj.Display();
            obj.ExternallArray();
            obj.ExternallArray();
            obj.NPatternArray();
            obj.ZPatternArray();

        }
    }
}

