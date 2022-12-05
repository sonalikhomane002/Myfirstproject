using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loop
{
    class Class3
    {
        //prime no 1 to 20

        static void Main(string[] args)
        {
            int[] ar = {2, 3, 4, 5, 6, 7,8 ,9,10};
            
            //int cnt = 0;
            int sum = 0;
            for(int i=0;i<ar.Length;i++)
            {
                bool isprime = true;
                for (int j=2;j<ar[i];j++)
                {
                    if(ar[i] % j==0)
                    {
                        isprime = false;
                        break;
                    }
                   // cnt++;
                }

                if(isprime==true)
                {
                    
                    Console.WriteLine(ar[i]);
                    sum = sum + ar[i];
                }

            }
            Console.WriteLine(sum);
        }
    }
}
