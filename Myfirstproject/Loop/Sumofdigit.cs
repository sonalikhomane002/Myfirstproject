using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loop
{
    class Sumofdigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the value of num");
            int num = int.Parse(Console.ReadLine());

            int sum = 0;
            while(num>0)
            {
                int rem = num % 10;
                sum = sum + rem;
                num = num / 10;

            }
            Console.WriteLine(sum);
        }
    }
}
