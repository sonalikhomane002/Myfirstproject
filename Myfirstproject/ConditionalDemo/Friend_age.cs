using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ConditionalDemo
{
    class Friend_age
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter my age");
            int myage = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter my Friend age");
            int myfriendage = int.Parse(Console.ReadLine());
            

            if(myage>myfriendage)
            {
                Console.WriteLine("Hi");
            }
            else if(myage<myfriendage)
            {
                Console.WriteLine("Good Morning");
            }
            Console.WriteLine("who are you");
        }
    }
}
