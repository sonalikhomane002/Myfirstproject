using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Basic
{
    class Sum
    {
        static void Main(string[] args)
        {
            int sum;
            Console.WriteLine("enter num1=");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num2=");
            int num2 = Convert.ToInt32(Console.ReadLine());
            sum = num1 + num2;
            Console.WriteLine(sum);
            
        }
    }
}
