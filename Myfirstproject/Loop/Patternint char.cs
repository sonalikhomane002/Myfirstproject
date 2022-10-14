using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loop
{
    class Patternint_char
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=4;i++)
            {
                if(i%2==0)
                {
                    char ch = 'A';
                    for(int j=1;j<=i;j++)
                    {
                        Console.WriteLine(ch);
                        ch++;
                    }
                }
                else
                {
                    for(int k=1;k<=i;k++)
                    {
                        Console.Write(k);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
