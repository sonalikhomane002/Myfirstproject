using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ConditionalDemo
{
    class EvenOdd2
    {
        static void Main(string[]args)
        {
            bool isEven;
            Console.WriteLine("enter the value of number" );
            int num = int.Parse(Console.ReadLine());
            isEven = (num % 2 == 0) ? true : false;
            Console.WriteLine(isEven);

        }
        
    }
}
