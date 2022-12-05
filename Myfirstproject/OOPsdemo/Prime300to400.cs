using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPsdemo
{
    class Prime300to400
    {
        static void Main(string[] args)
        {
            int no, cnt = 2, prime = 1;
            Console.WriteLine("enter the value of no");
            no = int.Parse(Console.ReadLine());

            while(cnt<=no/2)
            {

                if(no%cnt==0)
                {
                    prime = 0;
                    break;

                }
                cnt++;
            }
            if(prime==1)
            {
                Console.WriteLine("prime");
            }
            else
            {
                Console.WriteLine("not prime");
            }
        }
    }
}
