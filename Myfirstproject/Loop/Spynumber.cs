using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loop
{
    class Spynumber
    {
        static void Main(string[] args)
        {
            int sum = 0; int multi = 1; int rem;
            Console.WriteLine("enter the value of number");
            int num = int.Parse(Console.ReadLine());

            while(num!=0)
            {
                rem = num % 10;
                sum = sum + rem;
                multi = multi * rem;
                num = num / 10;
            }
            if(sum==multi)
            {
                Console.WriteLine("Spy number");
            }
            else
            {
                Console.WriteLine("not Spy number");
            }

         }

    }
      
    
}
