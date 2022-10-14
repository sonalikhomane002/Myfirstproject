using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loop
{
    class Blackredwhite
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the value of num");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                if (num > 2 && num < 8)
                {
                    Console.WriteLine("green");
                }
                else
                {
                    Console.WriteLine("red");
                }
            }
            else
            {
                 if(num>8)
                {
                    Console.WriteLine("white");
                }
                else
                {
                    Console.WriteLine("black");
                }
            }
             
           
    

        }
    }
}
