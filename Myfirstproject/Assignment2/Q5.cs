using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Assignment2
{
    class Q5
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Enter the value of num");
            int num = int.Parse(Console.ReadLine());
            if(num%5==0&&num%11==0)
            {
                Console.WriteLine("number is divisible by 5 and 11");
            }
            else
            {
                Console.WriteLine("num is not divisible by 5 and 11");
            }
        }
    }
}
