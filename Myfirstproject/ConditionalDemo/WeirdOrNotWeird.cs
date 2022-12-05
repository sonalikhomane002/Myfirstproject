using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ConditionalDemo
{
    class WeirdOrNotWeird
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the value of num");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num%2!=0)
                Console.WriteLine("Weird");
            else
                if(num>2&&num<=5)
                Console.WriteLine("Not Weird");
                else if(num>6&&num<=20)
                Console.WriteLine("Weird");
                else if(num>20)
                Console.WriteLine("Not Weird");
            
               
            
        }
    }
}
