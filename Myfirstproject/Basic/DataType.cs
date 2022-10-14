using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Basic
{
    class DataType
    {
        static void Main(string[]args)
        {
            byte mybyte;
            mybyte = 56;
            Console.WriteLine(mybyte);

            sbyte mybyte2 = -78;
            Console.WriteLine(mybyte+" "+mybyte2);


            short myshortvalue = 4765;
            short mysvalue = -3456;

            Console.WriteLine(myshortvalue+" "+mysvalue);


            int num1 = 2345;
            int num2 = -2345;
            Console.WriteLine(num1+" "+num2);


            long mylongvalue = 87635321567776;
            long mylongv = 98765432123;
            Console.WriteLine(mylongvalue+" "+mylongv);


            double myper = 70.30;
            float myf = 67.56f;
            Console.WriteLine(myper);
            Console.WriteLine(myf);

            char ch = 'y';
            char ch1 = '7';
            char ch2 = '#';

            Console.WriteLine(ch1+" "+ch+" "+ch2);


            bool ischeck = true;
            Console.WriteLine(ischeck);


            string  city = "my city pune";
            Console.WriteLine(city);



        }
    }
}
