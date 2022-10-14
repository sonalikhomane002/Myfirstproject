using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loop
{
    class task1111
    {
        static void Main(string[] args)
        {
            /*int fact = 1;
            Console.WriteLine("enter the no");
            int num = int.Parse(Console.ReadLine());
            
            for(int i=1;i<=num;i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
            fact = 1;
            while(num>0) 
            {
                fact = fact * num;
                num--;
            }
            Console.WriteLine(fact);*/
            bool isrem = true;
            Console.WriteLine("enter the no");
            int num = int.Parse(Console.ReadLine());
            //11051>0
            while (num > 0)
            {
               
                int rem = num % 10;
               // if (rem == 0 || rem == 1)
               // {
                    
                   // Console.WriteLine("valid");
                //}
                 if (rem > 1)
                {
                    isrem = false;
                   // Console.WriteLine("invalid");
                }
                

                num = num / 10;




            }
            if(isrem == true)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("invalid");
            }

        }
    }
}