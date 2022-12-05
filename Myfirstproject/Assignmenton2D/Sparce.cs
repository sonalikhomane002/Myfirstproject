using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Assignmenton2D
{
    class Sparce
    {
        int[,] matrix = new int[3, 3];
        public void Accept()
        {
            Console.WriteLine("Enter Matrix := ");
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = int.Parse(Console.ReadLine());
        }
        public void display()
        {
            Console.WriteLine("Matrix element ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write(matrix[i, j] + " ");
                Console.WriteLine("");

            }
        }

        public void CheckSparse()
        {
            int count = 0;
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        count++;

                    }
                }
            }

            if (count > (row * col) / 2)
                    Console.WriteLine("Sparse");

            else
                    Console.WriteLine("Not sparse");
       
        }
        static void Main(string[] args)
        {
            Sparce obj = new Sparce();
            obj.Accept();
            obj.display();
            obj.CheckSparse();


        }
    }
}
