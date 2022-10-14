using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Basic
{
    class Leapyear
    {
        static void Main(string[]args)
        {

            Console.WriteLine("enter the year");
            int year = int.Parse(Console.ReadLine());
            if (year % 4 == 0)
            {
                Console.WriteLine("year is leap year");

            }
            else
            {
                Console.WriteLine("year is not leap");
            }
            

            
        }
    }
}
