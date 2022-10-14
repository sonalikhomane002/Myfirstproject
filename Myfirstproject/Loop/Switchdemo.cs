using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loop
{
    class Switchdemo
    {
        static void Main(string[] args)
        {
            int result;
            Console.WriteLine("enter the num1");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the num1");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("1.Addition \n2.Substraction \n3.Multiplication \n4.Division");
            Console.WriteLine("enter your choice");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            { 
                case 1:
                    result = a + b;
                    Console.WriteLine("The addition is" + result);
                    break;
                case 2:
                    int substraction = a - b;
                    Console.WriteLine("The substraction is=",a-b);
                    break;
                case 3:
                    int multi = a * b;
                    Console.WriteLine("The Multiplication is=", a * b);
                    break;
                case 4:
                    float div = a / b;
                    Console.WriteLine("The Division is="+ div);
                    break;
                default:
                    Console.WriteLine("invalid statement");
                    break;
            }

            

            
            
        }
    }
}
