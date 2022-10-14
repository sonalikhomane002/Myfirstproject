using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Basic
{
    class Simpleinterest
    {
        static void Main(string[]args)
        {
            float si;
            Console.WriteLine("enter the Principal Amount");
            float Principle= float.Parse(Console.ReadLine());
            Console.WriteLine("enter Rate");
            float R = float.Parse(Console.ReadLine());
            Console.WriteLine("enter the time period");
            float T = float.Parse(Console.ReadLine());
            si = (Principle * R * T) / 100;
            Console.WriteLine(si);
        }
    }
}
