using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loop
{
   
    class Pattern
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <=5;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
    class Pattern1
    {
        static void Main(string[] args)
        {
            int n = 4;
            int m = 5;
            for(int i=1;i<=n;i++)
            {
                for(int j=1;j<=m;j++)
                {
                    if (i == 1 || j == 1 || i == n || j == m)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
        }
    }
    class Pattern2
    {
        static void Main(string[] args)
        {
            int n = 4;
            for(int i=1;i<=n;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
  
    class Pattern3
    {
        static void Main(string[] args)
        {
            for(int i=4;i>=1;i--)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
    class Pattern4
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 4; i++)
            {
                for (int k = 4; k > i; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }




}
