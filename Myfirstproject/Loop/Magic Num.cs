using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loop
{
    class Magic_Num
    {
        static void Main(string[] args)
        {
            int magic_number = 45;

            for(; ;)
            {
                Console.WriteLine("enter the num");
                int num = int.Parse(Console.ReadLine());

                if(num<magic_number)
                {
                    Console.WriteLine("number is less please try again");
                    continue;
                }
                else if(num>magic_number)
                {
                    Console.WriteLine("number is greater please try again");
                    continue;

                }
                else
                {
                    Console.WriteLine("gussing number is correct....thank you");
                    break;
                }
            }
        }
    }
}
