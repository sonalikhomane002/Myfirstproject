using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ConditionalDemo
{

    class Evenumsum
    {
        //sum of all even num between 1 to 30;
        static void Main(string[] args)
        {
            int i;
            int sum = 0;
            Console.WriteLine("enter the value of num");
            int num = int.Parse(Console.ReadLine());
            for (i = 1; i <= num; i=i+2)
                
                
            {
                sum = sum + i;
               

            }
            Console.WriteLine(sum);
        }
    }
}
