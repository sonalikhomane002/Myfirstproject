using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Assignmenton2D
{
    class Substract2DArr
    {
        int[,] arr1 = new int[2, 2];
        int[,] arr2 = new int[2, 2];
        int[,] arr3 = new int[2, 2];

        public void Accept1()
        {
            Console.WriteLine("enter 1 st Matrix");
            for(int i=0;i<arr1.GetLength(0);i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                    arr1[i, j] = int.Parse(Console.ReadLine());

            }
        }
        public void Accept2()
        {
            Console.WriteLine("Enter 2 nd Matrix");
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                    arr2[i, j] = int.Parse(Console.ReadLine());

            }
        }
        public void Display()
        {
            Console.WriteLine("first Matrix is");
            for(int i=0;i<arr1.GetLength(0);i++)
            {
                for(int j=0;j<arr1.GetLength(1);j++)

                    Console.Write(arr1[i,j]+" ");
                Console.WriteLine("");
            }
        }
        public void Display2()
        {

            Console.WriteLine("Second Matrix is");
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                    Console.Write(arr2[i, j] + " ");
                Console.WriteLine("");
            }
        }
        public void Substract()
        {
            Console.WriteLine("Substraction of Matrix is ");
            for(int i=0;i<arr3.GetLength(0);i++)
            {
                for (int j = 0; j < arr3.GetLength(1); j++)
                    arr3[i, j] = arr1[i, j] - arr2[i, j];
            }
            for (int i= 0; i < arr3.GetLength(0); i++)
            {
                for (int j = 0; j < arr3.GetLength(1); j++)
                    Console.Write(arr3[i, j] + " ");
                Console.WriteLine("");

            }
        }
        static void Main(string[] args)
        {
            Substract2DArr obj = new Substract2DArr();
            obj.Accept1();
            obj.Accept2();
            obj.Display();
            obj.Display2();
            obj.Substract();

        }


    }
}
