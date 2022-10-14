using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loop
{
    class AverageofPrime
    {
        static void Main(string[] args)
        {

            int count = 2;int sum = 3;
            for (int i = 3; i <= 10; i++)
            {
                bool flag = true;
                for(int j=2;j<i;j++)
                {
                    if (i % j == 0)
                    {
                        flag = false;
                        break;
                    }

                }
                if(flag==true)
                {
                    sum = sum + i;
                    count++;
                }
                
            }

            float Average = (float)sum / count;
            Console.WriteLine(Average);
     
                
          
        }
    }
    
}
