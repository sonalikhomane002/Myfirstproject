using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPsdemo
{
    class Grosssal
    {
        public float gross;
        public float DA;
        public float HRA;


        public void calcuateSalary(float basic)
        {
            if(basic<=10000)
            {
                DA = basic * 0.8f;
                HRA = basic * 0.2f;
            }
            else if(basic<=20000)
            {
                DA = basic * 0.9f;
                HRA = basic * 0.25f;

            }
            else
            {
                DA = basic * 0.95f;
                HRA = basic * 0.3f;

            }
            gross = basic + DA + HRA;
            Console.WriteLine(gross);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the basic salary of employee");
            float basic = float.Parse(Console.ReadLine());
            
            Grosssal grosssal = new Grosssal();
            grosssal.calcuateSalary(basic);
        }
    }
}
