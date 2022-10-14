using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ConditionalDemo
{
  
    class Percentage_class
    {
        static void Main(string[] args)
        {
            float total, Percentage;
            Console.WriteLine("enter the 1st sub mark");
            int sub1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the 2nd sub mark");
            int sub2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the 3rd sub mark");
            int sub3 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the 4th sub mark");
            int sub4 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the 5th sub mark");
            int sub5 = int.Parse(Console.ReadLine());
            total = sub1 + sub2 + sub3 + sub4 + sub5;
            Percentage = total / 5;
            Console.WriteLine();
            if (Percentage > 70)
            {
                Console.WriteLine("Distinction");
            }
            else if (Percentage < 70 && Percentage >= 60)
            {
                Console.WriteLine("First Class");
            }
            else if (Percentage < 60 && Percentage >= 50)
            {
                Console.WriteLine("Second Class");
            }
            else if (Percentage < 50 && Percentage >= 35)
            {
                Console.WriteLine("pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }


        }
    }
}