using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loop
{
    class Average_of_Digits
    {
        static void Main(string[] args)
        {
            int total;
            float average;
            int rem;

            Console.WriteLine("enter the value of num");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            
            while(num>0)
            {
                rem = num % 10;
                sum = sum + rem;
               
                Console.WriteLine(sum);
                total = sum + rem;
                average = total / 3;
                

            }
            Console.WriteLine(sum);
            Console.WriteLine();

        }
    }
}
