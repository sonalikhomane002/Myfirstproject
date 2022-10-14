using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ConditionalDemo
{
    class Student
    {
        static void Main(string[] args)
        {
             
            Console.WriteLine("enter the Passout year");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("enter  the Percentage");
            int per = int.Parse(Console.ReadLine());

            if(year==2021)
            {
                if (per > 60)
                {
                    Console.WriteLine("student is selected");
                }
                else
                {
                    Console.WriteLine("percentage is less not selected");
                }

            }
            else
            {
                Console.WriteLine("student not selected");
            }


        }
    }
}
