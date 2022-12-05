using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Constructor
{
    class Sum
    {
       
        static void Main(string[] args)
        {
            int num1 = 6;
             int num2 = 5;
             int  res=0;
            

            for(int i=0;i<num1;i++)
            {
                res+=num2;
               
            }
           Console.WriteLine(res);
        }
    }
}
