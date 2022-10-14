using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loop
{
    class Break
    {
        static void Main(string[] args)
        {
           
    /*        for(int i = 1; i <= 5; i++)
            {
                if (i == 3)
                {
                    break;
                    
                }
                Console.WriteLine(i);

            }
            Console.WriteLine();*/

            Console.WriteLine("enter the value of num");
            int num = int.Parse(Console.ReadLine());

            int count = 0;
            int Original = num;

            while (num > 0)
            {
                num = num / 10;
                count++;
            }
            num = Original;
            double sum = 0;
            while (num > 0)
            {
                double rem = num / 10;
                double power = (Math.Pow(rem, count));
                sum = sum + power;

            }
            if (num == sum)
            {
                Console.WriteLine("Disarium");
            }
            else
            {
                Console.WriteLine("Not Dissarium");
            }
        }
    }
}
