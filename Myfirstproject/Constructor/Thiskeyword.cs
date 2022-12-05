using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Constructor
{

    //imp for interview
    class Thiskeword
    {
        int a, b;

        public Thiskeword()
        {
            Console.WriteLine("No parameterized constructor called");
        }
        public Thiskeword(int a):this()
        {
           
            this.a = a;
            Console.WriteLine(a);


        }
        public Thiskeword(int a, int b) : this(a)
        {
            this.a = a;
            this.b = b;
            Console.WriteLine(a+"  "+b);

        }
       
        static void Main(string[] args)
        {
            Thiskeword obj = new Thiskeword(2,5);
            Console.ReadKey();
        }

    }
}
