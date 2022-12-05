using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Assignmenton2D
{
    //sum of lower traingular matrix
    class MatrixL
    {
        int[,] matrix = new int[3, 3]
         {
            {1,0,0},
            {4,5,0},
            {7,8,9}
         };

        public void Display()
        { 
            Console.WriteLine("Matrix is := ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write(matrix[i, j] + " ");
                Console.WriteLine("");
            }
        }
        public bool IsLowerTriangular()
        {
            int sum = 0;
            bool lowerTriangular = true;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i < j)
                    {
                        if (matrix[i, j] != 0)
                        {
                            lowerTriangular = false;
                          
                            break;
                            
                        }
                        sum = sum + matrix[i,j];
                        Console.WriteLine(sum);

                    }
                }
            }
            return lowerTriangular;
           
        }
        static void Main(string[] args)
        {
            MatrixL obj = new MatrixL();
            obj.Display();
            if (obj.IsLowerTriangular())

                Console.WriteLine("Given Matrix is Lower Triangular Matrix");
           
               
            Console.ReadKey();


        }
    }
}
