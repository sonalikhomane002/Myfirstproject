using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Basic
{
    class Percentage
    {
        static void Main(string[]args)
        {
            
            float total, percentage, average;
            Console.WriteLine("enter the sub1 mark");
            float sub1 = float.Parse(Console.ReadLine());
            Console.WriteLine("enter the sub2 mark");
            float sub2 = float.Parse(Console.ReadLine());
            Console.WriteLine("enter the sub3 mark");
            float sub3 = float.Parse(Console.ReadLine());
            Console.WriteLine("enter the sub4 mark");
            float sub4 = float.Parse(Console.ReadLine());
            Console.WriteLine("enter the sub5 mark");
            float sub5 = float.Parse(Console.ReadLine());
            total = sub1 + sub2 + sub3 + sub4 + sub5;
            average = total / 5;
            percentage = (total / 500) * 100;
            Console.WriteLine(total);
            Console.WriteLine(average);
            Console.WriteLine(percentage);

        }
    }
}
