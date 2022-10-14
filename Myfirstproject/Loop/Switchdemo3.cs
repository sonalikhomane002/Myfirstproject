using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loop
{
    class Switchdemo3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the city");
            string city = Console.ReadLine();

            switch(city)
            {
                case "mumbai": 
                    Console.WriteLine("my city is mumbai");
                    break;
                case "pune":
                    Console.WriteLine("my city is pune");
                    break;
                    default:
                    Console.WriteLine("my city is not mumbai or pune");
                    break;
            }
        }
    }
}
