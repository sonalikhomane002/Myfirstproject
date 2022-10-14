using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ConditionalDemo
{
    class Arithmaticopertion
    {
        static void Main(string[]args)
        {
            int result;
            Console.WriteLine("enter the value of num1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the value of num2");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("select the operation");
            Console.WriteLine("option");
            Console.WriteLine(1+"Addition\n" +2+ "substraction\n"+3+ "Multiplication\n"+4+ "Division");
           

            Console.WriteLine("enter the option you want to perform");
            int option = int.Parse(Console.ReadLine());

            if(option==1)
            {
                Console.WriteLine(result =num1+num2);
                Console.WriteLine("The Result of Addition is" + result);
            }
            else if(option==2)
            {
                Console.WriteLine(result = num1 - num2);
                Console.WriteLine("The Result of substraction is"   +  result);

            }
            else if(option==3)
            {
                Console.WriteLine(result = num1 * num2);
                Console.WriteLine("The Result of Multiplication is" + result);

            }
            else if(option==4)
            {
                Console.WriteLine(result = num1 / num2);
                Console.WriteLine("The Result of Division is" + result);
            }
        }
    }
}
