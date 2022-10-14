using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loop
{
    class Fact
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the value of num");
            int num = int.Parse(Console.ReadLine());

            bool isprime = true;

            for(int i=2;i<num;i++)
            {
                if(num % i == 0)
                {
                    isprime = false;
                }
                
            }
            if(isprime==true)
            {
                Console.WriteLine("prime");
            }
            else
            {
                Console.WriteLine("not prime");
            }
        }
    }
}
