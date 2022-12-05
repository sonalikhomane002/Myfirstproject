using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Constructor
{
    class UseofThisKeyword
    {
        int a, b, sum;

        public UseofThisKeyword()
        {
            a = 0;
            b = 0;
            sum = a + b;
        }
        public UseofThisKeyword(int a)
        {
            Console.WriteLine("Single parameterized constructor called");
            this.a = a;
            this.b = a;
            sum = a + b;


        }
        public UseofThisKeyword(int a,int b):this(a)
        {
            this.a = a;
            this.b = b;

        }
        public void putinfo()
        {
            Console.WriteLine("Addition is"+sum);
        }
        static void Main(string[] args)
        {
            UseofThisKeyword obj = new UseofThisKeyword();
            obj.putinfo();
            obj = new UseofThisKeyword(3);
            obj.putinfo();
            obj = new UseofThisKeyword(10);
            obj.putinfo();

        }
    }
}
