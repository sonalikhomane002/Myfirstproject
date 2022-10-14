using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Basic
{
    class UserValue
    {
        static void Main(string[]args)
        {
            int num;
            Console.WriteLine("Enter the value");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine(num);
            Console.WriteLine(num*3);

            
            Console.WriteLine("Enter the Percentage");
            float per = float.Parse (Console.ReadLine());
            Console.WriteLine("per"+per);

            Console.WriteLine("enter the city");
            string city = Console.ReadLine();
            Console.WriteLine(city);

            Console.WriteLine("enter the value");
            char ch = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("my char="+ch);

        }
    }
}
