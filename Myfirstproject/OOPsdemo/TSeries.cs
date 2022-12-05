using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPsdemo
{
    class TSeries
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the num");
            int n = int.Parse(Console.ReadLine());
            int no = 2;
            for(int i=1;i<=n;i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(-no);
                }
                else
                {
                    Console.WriteLine(no);
                }

                no+=2;
            }
            
        }
    }
}
