using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPsdemo
{
    class FactorOfNum
    {
        
        public int sum = 0;
        public int num;

        public void Accept_detail(int x)
        {
            num = x;
        }


        public void Calculate()
        {
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;

                }
            }

        }
        public void Display()
        {
            
            Console.WriteLine(sum);
        }
        static void Main(string[] args)
        {
            FactorOfNum factorofnum = new FactorOfNum();
            factorofnum.Accept_detail(8);
            factorofnum.Calculate();
            factorofnum.Display();
        }

    }

}
