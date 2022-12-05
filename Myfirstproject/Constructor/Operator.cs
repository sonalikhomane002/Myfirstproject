using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Constructor
{
    class Operator
    {
        static void Main(string[] args)
        {
            /*int a = 10;
            int b = 10;

            int c = a + b++;
            Console.WriteLine(a+" "+b+" "+c);
*/

            /*int a = 10;
            int b = 10;
            int c = a + (++b);
            Console.WriteLine(a+" "+b+" "+c);
*/

            /* int a = 10;
            // Console.WriteLine($"{ a++} {a++} {++a}");

             Console.WriteLine($"{ a++} { --a} {--a} {a++} {++a}");*/

            int a = 5;
            int b = 2;
            int c;

            c = a * b + (a++ + --b) - b;
            Console.WriteLine(a+" "+b+" "+c);
        }
    }
}
