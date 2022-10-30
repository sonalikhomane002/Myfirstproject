using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.AssinmentVloop
{
    class Harshadnumberor_not
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the value of num");
            int num = int.Parse(Console.ReadLine());

            int rem;
            int sum = 0;
            int temp = num;

            while (num > 0)
            {
                rem = num % 10;
                sum = sum + rem;
                num = num / 10;


            }
            if (temp % sum == 0)
            {
                Console.WriteLine("Harshad num");
            }
            else
            {
                Console.WriteLine("not Harshad num");
            }

        }
    
    }
}
