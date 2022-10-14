using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loop
{
    class Kaprekar
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter the value of num");
            int num = int.Parse(Console.ReadLine());

            int count = 0;
            int real = num;
            int t = num * num;

            while (num > 0)
            {
                int rem = num % 10;
                count++;

            }
                num = real;
                int power = (int)(Math.Pow(10, count));
                int end = t % power;
                int start = t % power;
                Console.WriteLine("end" + end);
                Console.WriteLine("start" + start);
                int sum = end + start;
            


                if (sum == real)
                {
                    Console.WriteLine("Kaprekar no");
                }
                else
                {
                    Console.WriteLine("not kaprekar");


                }
            


        }
    }
}