using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Basic
{
    class Swapnumber
    {
        static void Main(string[] args)
        {
            int number1 = 10, number2 = 20, temp = 0;
            Console.WriteLine("number before swap="+number1 +" "+number2);
            temp = number1;
            number1 = number2;
            number2 = temp;

            Console.WriteLine("number after swapping"+" "+number1+" "+number2);
        }
    }
    
}
