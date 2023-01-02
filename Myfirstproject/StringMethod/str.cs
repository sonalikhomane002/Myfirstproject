using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StringMethod
{
    //pattern 
              
    class str
    {
        static void Main(string[] args)
        {
            string str = "i like india country";
            int cnt = str.Split(' ').Length;
            int count = 0;

            for (int i=0;i<str.Length;i++)
            {
                count = 0;
                for(int j=0;j<str.Length;j++)
                {
                   if(str[j]==' ')
                    {
                        count++;
                    }

                    if(count==i)
                    {
                        break;
                    }

                    Console.Write(str[j]);
                }
                
                if(cnt == i)
                {
                    break;
                }

                Console.WriteLine();
            }
        }
    }
}
