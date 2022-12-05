using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Constructor
{
    // call by value and call by Reference(swapping example)
    class ParmeterPassing
    {
        int a, b;
        public ParmeterPassing()
        {
            a = b = 0;
        }
        public ParmeterPassing(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public void Display()
        {
            Console.WriteLine("First : " + a + " Second : " + b);
        }
        static void Swap(int x, int y)
        {
            int t = x;
            x = y;
            y = t;
            Console.WriteLine("Inside function : First: " + x + " Second: " + y);
        }
        static void Swap1(ref int x, ref int y)
        {
            int t = x;
            x = y;
            y = t;
            Console.WriteLine("Inside function : First: " + x + " Second: " + y);
        }
        static void Main(string[] args)
        {
            ParmeterPassing P = new ParmeterPassing(4, 7);
            int a = 8, b = 4;
            Console.WriteLine("Call by Value");
            Console.WriteLine("Before function: First: " + a + " Second: " + b);
            Swap(a, b);
            Console.WriteLine("After function: First: " + a + " Second: " + b);
            Console.WriteLine("\nCall by Reference");
            Console.WriteLine("Before function: First: "+a+" Second: "+b);
            Swap1(ref a, ref b);
            Console.WriteLine("After function: First: "+a+" Second: "+b);

        }
    }
}
