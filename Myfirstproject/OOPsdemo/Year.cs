using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPsdemo
{
    class Year
    {
        static void Main(string[] args)
        {
            int days, yr, m, d;
            Console.WriteLine("enter days=");

            days = int.Parse(Console.ReadLine());
            if(days>=365)
            {
                yr = days / 365;
                Console.WriteLine("Year:="+yr);
            }
            m = (days % 365) / 30;
            Console.WriteLine("Month="+m);
            d = (days % 365) % 30;
            Console.WriteLine("Days:="+d);
                
        }
    }
}
