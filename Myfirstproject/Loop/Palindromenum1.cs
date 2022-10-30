using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loop
{
    class Palindromenum1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the value of num");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int sum = 0;
            while(num>0)
            {
                
                int rem = num % 10;
                sum = (sum * 10 )+ rem;
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
