using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loop
{
    class Trymorphic
    {
        static void Main(string[] args)
        {
            int c;
            int rem;
            Console.WriteLine("enter the value of num");
            int num = int.Parse(Console.ReadLine());
            int temp = num;

          
            c = num * num * num;
            rem = c % 10;


          
            if(temp==rem)
            {
                Console.WriteLine("Trymorphic");
            }
            else
            {
                Console.WriteLine("Not Trymorphic");
            }


        }
    }
}
