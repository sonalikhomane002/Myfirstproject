using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.TwoDArray
{
    class MaxNo
    {
        int[,] matrix = new int[3, 3];
        int[,] matrix1 = new int[3, 2];
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
        public void Max()
        {
            int k = 0, l = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int max = matrix[i,0];
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];

                    }
                }
                matrix1[k, 0] = max;


                max = matrix[0, i];
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[j, i] > max)
                    {
                        max = matrix[j, i];
                    }
                }

                matrix1[l, 1] = max;
                
                    l++;
                

                k++;

            }

            
        }
        public void Display()
        {
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                    Console.Write(matrix1[i, j] + " ");
                Console.WriteLine("");

            }
        }

        static void Main(string[] args)
        {
               MaxNo obj = new MaxNo();
               obj.accept();
               obj.display();
            obj.Max();
            obj.Display();
                
        }


    }
}
