using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Basic
{
    class Swap1
    {
            static void Main(string[] args)
            {
                int a = 5, b = 10;
                Console.WriteLine("a and b before swapping" + a + " " + b);
                a = a * b;//(5*10) a=50
                b = a / b;//(50/10) b=5
                a = a / b;//5(50/5) a=10
                Console.WriteLine("a and b after swapping" + a + " " + b);
            }
    }

    class Swapnumber1
    {
        static void Main(string[] args)
        {
            int number1 = 10, number2 = 20, temp = 0;
            Console.WriteLine("number before swap=" + number1 + " " + number2);
            temp = number1;
            number1 = number2;
            number2 = temp;

            Console.WriteLine("number after swapping" + " " + number1 + " " + number2);
        }
    }
}
