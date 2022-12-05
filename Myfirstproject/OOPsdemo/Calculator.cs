using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPsdemo
{
    class Calculator
    {
        
        public void CalculatorUsingSwitch()
        {
            Console.WriteLine("enter the 1st no");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the 2nd no");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("select operation");
            Console.WriteLine("Addition-a: Subtraction-s: Multiplication-m: Division-d: ");
            char ch = Convert.ToChar(Console.ReadLine());
        
            switch (ch)
            {
                case 'a':
                    Console.WriteLine("Sum of the given two numbers: " + (a + b));
                    break;
                case 's':
                    Console.WriteLine("Sustraction of the two numbers: " + (a - b));
                    break;
                case 'm':
                    Console.WriteLine("Multiplication of the two numbers: " + (a * b));
                    break;
                case 'd':
                    Console.WriteLine("Divisionof the two numbers: " + (a / b));
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
        }
    
        static void Main(string[] args)
        {

            Calculator obj = new Calculator();
            obj.CalculatorUsingSwitch();


           
        }
    }
}
