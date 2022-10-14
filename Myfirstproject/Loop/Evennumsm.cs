using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loop
{
    class Evennumsm
    {
        static void Main(string[] args)
        {
            int rem;
            Console.WriteLine("enter the value of num");
            int num = int.Parse(Console.ReadLine());

            int Sum=0;
            while(num>0)
            {
                rem = num % 10;

                 if(rem % 2 == 0)
                 {
                    Sum = Sum + rem;

                 }
                num = num / 10;
                
                
                    
                


            }
            Console.WriteLine(Sum);
            
            
        }
    }
}
