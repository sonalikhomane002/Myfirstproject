using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Assignmenton2D
{
    class MaxNoRow
    {
        int[,] matrix = new int[2, 3];
        
        public void accept()
        {
            Console.WriteLine("Enter matrix element");
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
        public void Max()
        {

            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int max = matrix[i, 0];
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];

                    }
                }
                matrix[i, 0] = max;
                Console.WriteLine(max);
                
            }

        }
        
        static void Main(string[] args)
        {
            MaxNoRow obj = new MaxNoRow();
                obj.accept();
                obj.display();
                obj.Max();
                

        }
        
    }
}