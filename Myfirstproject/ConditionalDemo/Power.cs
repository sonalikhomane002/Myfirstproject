using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ConditionalDemo
{
    class Power
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("enter the value of base");
            int Base= int.Parse(Console.ReadLine());
            Console.WriteLine("enter the value of exponent");
            int Exp = int.Parse(Console.ReadLine());
            int Power = 1;
            for(int i=1;i<=Exp;i++)
            {
               Power = Power* Base;

            }
            Console.WriteLine(Power);



            



        }
    }
}
