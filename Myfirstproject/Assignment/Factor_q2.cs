using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Assignment
{
    class Factor_q2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the vale of num");
            int num = int.Parse(Console.ReadLine());

            for(int i=1;i<=num;i++)
            {
                if(num%i==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
