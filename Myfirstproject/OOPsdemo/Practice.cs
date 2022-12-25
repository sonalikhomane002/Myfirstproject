using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPsdemo
{
    class Practice
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the value of num");
            int num = int.Parse(Console.ReadLine());

            int reverse = 0;
            while (num > 0)
            {
                int r = num % 10;
                reverse = reverse * 10 + r;
                num = num / 10;
            }
            Console.WriteLine(reverse);

        }
    }
    public class HappyNumber
    {
           
        public static int IsHappyNumber(int num)
        {
            int rem = 0, sum = 0;
        
            while (num > 0)
            {
                rem = num % 10;
                sum = sum + (rem * rem);
                num = num / 10;
            }
            return sum;
        }

        public static void Main()
        {
            Console.WriteLine("Enter a Number : ");
            int Number = Convert.ToInt16(Console.ReadLine());
            int result = Number;
            while (result != 1 && result != 4)
            {
                result = IsHappyNumber(result);
            }

          
            if (result == 1)
                Console.WriteLine(Number + " is a happy number");

          
            else if (result == 4)
                Console.WriteLine(Number + " is not a happy number");

            Console.ReadKey();
        }
    }
}
