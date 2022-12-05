using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPsdemo
{
 
    //Nesting Memberfunction
    class Sample
    {
        int a, b;
        public void GetInfo(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public void GetInfo()
        {
            this.a = 1;
            this.b = 8;
        }
        public void GetInfo(int n)
        {
            a = b = n;
        }
        public int Greatest()
        {
            if (a > b)
                return a;
            else
                return b;
        }
        public void PutInfo()
        {
            Console.WriteLine("Gretest is := " + Greatest());
        }
    

        static void Main(string[] args)
        {
            Sample sample = new Sample();
            sample.GetInfo(6);
            sample.PutInfo();
            Console.ReadKey();
        }
    }
}
