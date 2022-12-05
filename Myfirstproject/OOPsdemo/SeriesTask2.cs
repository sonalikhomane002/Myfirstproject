using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPsdemo
{
    class SeriesTask2
    {
        static void Main(string[] args)
        {
            int j= 1;
            Console.WriteLine("enter the terms");
            int n = int.Parse(Console.ReadLine());
            for(int i=1;j<=n;j++)
            {
               
                Console.WriteLine(i+" ");
                i = i + j;
            }
        }
    }
}
