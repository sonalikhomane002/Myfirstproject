using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ExceptionDemo
{
    class Class1
    {
        static string s;
        static void Main(string[] args)
        {
            try
            {
                if(s==null)
                {
                    throw new Exception();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Handeled..."+e.ToString());
            }
            Console.WriteLine("hi.......");
        }
    }
    class TestExcception
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            int sum = 0;
            try
            {
                int x = 10 / sum;
                Console.WriteLine("xxx"+x);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Handled...."+e.ToString());
            }
            Console.WriteLine("Hi");
            Console.WriteLine("Good");
        }
    }
}
