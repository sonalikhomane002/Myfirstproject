using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPsdemo
{

    class Month
    {
        int days;
        
        public void NumberOfDays(int month)
        {
         

            switch(month)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    days = 30;
                    Console.WriteLine("30 days in this month");
                    break;

                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    days = 31;
                    Console.WriteLine("31 days in this month");
                    break;

                case 2:
                    days = 28;
                    Console.WriteLine("28 days in this month");
                    break;

                default:
                    days = 0;
                    Console.WriteLine("invlid");
                    break;
            }

        }
       
        static void Main(string[] args)
        {
            Console.WriteLine(" enter the month");
            int month = int.Parse(Console.ReadLine());
            Month obj = new Month();
            obj.NumberOfDays(month);

        }
    }
}
