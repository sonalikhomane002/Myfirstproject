using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.TwoDArray
{
    //Upper Traingular Matrix.
    class Matrix1
    {
        int[,] matrix = new int[3, 3]
        {
            {1,2,3},
            {0,5,6},                                                                                                                                                                                                                        
            {0,0,9 }
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
        public bool IsUpperTriangular()
        {
            bool upperTriangular = true;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i >j)
                    {
                        if (matrix[i, j] != 0)
                        {
                            upperTriangular = false;
                            break;
                        }

                    }
                }
            }
            return upperTriangular;
        }
        static void Main(string[] args)
        {
            Matrix1 obj = new Matrix1();
            obj.Display();
            if (obj.IsUpperTriangular())
                Console.WriteLine("Given Matrix is Upper Triangular Matrix");
            else
                Console.WriteLine("Not Upper Triangular Matrix");
            Console.ReadKey();

        }
    }
}
