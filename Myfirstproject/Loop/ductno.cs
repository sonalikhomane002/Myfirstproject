using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loop
{
    class ductno
    {
        static void Main(string[] args)
        {


            int count = 0;
            Console.WriteLine("enter the value of num");
            string n = Console.ReadLine();
           // int num = Convert.ToInt32(n);
            //"103" n[0] = 1 n[1] = 0 n[2] = 3
            //count = 1
            for (int i = 1; i < n.Length; i++)
            {

                if (n[i] == '0')
                {
                    count++;
                    //Console.WriteLine("duck num");
                }
            }
            if (count > 0 && (n[0] == '0'|| n[0] != '0'))
            {
                Console.WriteLine("duck no");
            }
            else 
            {
                Console.WriteLine("not duck");
            }











        }
    }
}
