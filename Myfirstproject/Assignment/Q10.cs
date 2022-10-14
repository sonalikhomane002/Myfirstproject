using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Assignment
{
    class Q10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the value of num");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the value of num");
            int num2 = int.Parse(Console.ReadLine());

            bool isPrime = true;
            for(int i=2;i<num1;i++)
            {
                if(num1%i==0)
                {
                    isPrime = false;
                    break;
                }
            }
            
                
            
            bool isPrime2 = true;
            for (int i = 2; i < num2; i++)
            {
                if (num2 % i == 0)
                {
                    isPrime2 = false;
                    break;
                }
            }
            if (isPrime2 && isPrime)
            {
                bool isTwinPrime = Math.Abs((num1 - num2)) == 2 ? true : false;
                if (isTwinPrime)
                {
                    Console.WriteLine("Numbers are twin prime");
                }
                else
                {
                    Console.WriteLine("Numbers are not twin prime");
                }
            }
            else
            {
                Console.WriteLine("Numbers are not twin prime");
            }

        }
    }
}
