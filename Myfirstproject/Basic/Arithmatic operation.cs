using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Basic
{
    class Arithmatic_operation
    {

        static void Main(string[] args)
        {
            int addition;
            Console.WriteLine("enter the num1=");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num2=");
            int num2 = Convert.ToInt32(Console.ReadLine());
            addition = num1 + num2;
            Console.WriteLine(addition);


        }
    }
    class Substraction
    {
        static void Main(string[] args)
        {
            int subtraction;
            Console.WriteLine("enter the num1=");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num2=");
            int num2 = Convert.ToInt32(Console.ReadLine());
            subtraction = num1 - num2;
            Console.WriteLine(subtraction);

        }
    }
    class Division
    {
        static void Main(string[] args)
        {
            int Division;
            Console.WriteLine("enter the num1=");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num2=");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Division = num1 / num2;
            Console.WriteLine(Division);


        }
    }
    class Multiplication
    {
        static void Main(string[]args)
        {
            int multiplication;
            Console.WriteLine("enter the num1=");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num2=");
            int num2 = Convert.ToInt32(Console.ReadLine());
            multiplication= num1 * num2;
            Console.WriteLine(multiplication);


        }
    }
}