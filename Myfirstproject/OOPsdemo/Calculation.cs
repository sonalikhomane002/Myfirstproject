using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPsdemo
{
    class Calculation
    {
        public void add(int a,int b)
        {
            int res = a + b;
            Console.WriteLine("Addition of 2 integer is"+res);
        }
        public void add(int a)
        {
            int res = a + 0;
            Console.WriteLine("Addition of 1 integer is"+res);
        }
        public void add(double a,double b)
        {
            double res = a + b;
            Console.WriteLine("Addition of 2 double is"+res);
        }
        static void Main(string[] args)
        {
            Calculation obj = new Calculation();
            obj.add(3, 2);
            obj.add(2);
            obj.add(4.5, 6.8);
            Console.ReadKey();
        }
    }
}
