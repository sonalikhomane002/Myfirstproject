using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Assignmenton2D
{
    class MinElementCol
    {

        int[,] matrix = new int[3, 3];

        public void accept()
        {
            Console.WriteLine("Enter matrix element");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = int.Parse(Console.ReadLine());
            }
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
        public void Min()
        {
            Console.WriteLine("columnwise  min number=");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int minc = matrix[0, i];
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[j, i] < minc)
                    {
                        minc = matrix[j, i];

                    }
                }
                Console.WriteLine(minc);
            }
        }

        static void Main(string[] args)
        {
            MinElementCol obj = new MinElementCol();
            obj.accept();
            obj.display();
            obj.Min();


        }
    }
    
}
