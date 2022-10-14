using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ConditionalDemo
{
    class Ternary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of num");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of num");
            int num2 = int.Parse(Console.ReadLine());
         //  string str = num1 > num2 ? "num1 is greater" : "num2 is greater";
            int x = num1 > num2 ? num1 : num2;
            Console.WriteLine("greater" + x);
           // Console.WriteLine(str);
            
        }
    }
}
