using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loop
{
    class Automorphic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the value of num");
            int num = int.Parse(Console.ReadLine());

            int square = 1;
            int count = 0;
            int Temp = num;
            while(num>0)
            {
                int digit = num % 10;
                count++;
                num = num / 10;

            }
            num = Temp;
            
                int power = 1;
                int b = 10;
                square = num * num;
            
            for(int i=1;i<=count;i++)
            {
                power = power * b;
            }
            Console.WriteLine(power);
            int last = square % power;
            if(num==last)
            {
                Console.WriteLine("Automorphic");
            }
            else
            {
                Console.WriteLine("not Automorphic");
            }
        }
    }
}
