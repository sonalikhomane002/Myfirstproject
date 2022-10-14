using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loop
{
    class TaskInteger
    {
        static void Main(string[] args)
        {
            
           bool Flag = true;
        for(int i=1;i<=5;i++)
            {
                bool ison = true;
                for (int j = 1; j <= 5; j++)
                {
                    if (Flag == true)
                    {
                        if (ison)
                        {
                            Console.Write("1");

                        }
                        else
                        {
                            Console.Write("0");
                        }
                    }
                    else
                    {
                        if (ison)
                        {
                            Console.Write("0");
                        }
                        else
                        {
                            Console.Write("1");
                        }
                    }

                    ison = !ison;
                
                }

                Flag = !Flag;
                Console.WriteLine();
            }

        }
    }
}
