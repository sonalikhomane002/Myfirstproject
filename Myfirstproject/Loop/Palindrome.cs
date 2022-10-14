using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loop
{
    class Palindrome
    {
        static void Main(string[] args)
        {
            int rem; int sum = 0;int temp;
            Console.WriteLine("enter the value of num");
            int num = int.Parse(Console.ReadLine());

            temp = num;
            while(num>0)
            {
                rem = num % 10;
                sum = (sum * 10) + rem;
                num = num / 10;

            }
            if(temp==sum)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("not Palindrome");
            }
        }
    }
}
