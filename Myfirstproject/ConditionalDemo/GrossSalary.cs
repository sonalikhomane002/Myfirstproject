using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ConditionalDemo
 {
    class GrossSalary
    {
        static void Main(string[] args)
        {
            float gross, DA, HRA;
            Console.WriteLine("enter the basic basic salery of Employee");
            float basic = float.Parse(Console.ReadLine());

            if (basic <= 10000)
            {
                 DA = basic* 0.8f;
                HRA = basic* 0.2f;
            }
            else if (basic<= 20000)
            {
                 DA = basic * 0.9f;
                 HRA = basic * 0.25f;

            }
            else
            {
                 DA = basic * 0.95f;
                 HRA = basic* 0.3f;

            }

              gross = basic +  HRA +  DA;
              Console.WriteLine(gross);




        }
    }
}
