using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loop
{
    class Armstrong_num
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the value of num");
            int num = int.Parse(Console.ReadLine());

            int temp = num;
            int sum = 0;

            while(num>0)
            {
                int r = num % 10;
                sum = sum + (r * r * r);
                num = num / 10;

            }
            
            if(temp==sum)
            {
                Console.WriteLine("number is Armstrong");
            }
            else
            {
                Console.WriteLine("number is not Armstrong");
            }
        }
    }
}
