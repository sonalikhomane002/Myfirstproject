using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Basic
{
    class YearWeekDays
    {
        static void Main(string[]args)
        {
            int year, Days, week;
            Console.WriteLine("Enter the Days");
            int Day = int.Parse(Console.ReadLine());
            year = Day / 365;
            Console.WriteLine("year="  +year);
            week = (Day % 365) / 7;
            Days = (Day % 365) % 7;
            Console.WriteLine("week="+week);
            Console.WriteLine("Day=" +Days);
            

        }
    }
}
