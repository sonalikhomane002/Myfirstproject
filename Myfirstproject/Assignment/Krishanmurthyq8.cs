using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Assignment
{
    class Krishanmurthyq8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the value of num");
            int num = int.Parse(Console.ReadLine());

            int sum = 0, temp, rem;
            for(temp=num;temp>0;temp=temp/10)
            {
                int fact = 1;
                rem = temp % 10;

                for(int i=1;i<=rem;i++)
                {
                    fact = fact * i;
                }
                sum = sum + fact;

            }
            if(num==sum)
            {
                Console.WriteLine("krishnmurthy no");
            }
            else
            {
                Console.WriteLine("not krishnmurthy no");
            }
        }
    }
}
