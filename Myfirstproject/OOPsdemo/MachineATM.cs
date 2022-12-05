using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPsdemo
{
    class MachineATM
    {
       
        public void CalculateNotes()
        {
            Console.WriteLine("enter the cash");
            int cash = int.Parse(Console.ReadLine());

            while (cash >= 0)
            {
                if (cash >= 2000)
                {
                    Console.WriteLine("no of 2000 notes:=" + (cash / 2000));
                    cash = cash % 2000;

                }
                else if (cash >= 500)
                {
                    Console.WriteLine("no of  500 notes:=" + (cash / 500));
                    cash = cash % 500;

                }
                else if (cash >= 200)
                {
                    Console.WriteLine("no of 200 notes:=" + (cash / 200));
                    cash = cash % 200;

                }
                
                else if (cash >= 100)
                {
                    Console.WriteLine("no of 100 notes:=" + (cash / 100));
                    cash = cash % 100;

                }
                else if (cash >= 50)
                {
                    Console.WriteLine("no of 50 notes:=" + (cash / 50));
                    cash = cash % 50;

                }
                else if (cash >= 10)
                {
                    Console.WriteLine("no of 10 notes:=" + (cash / 10));
                    cash = cash % 10;

                }
                else if (cash >= 1)
                {
                    Console.WriteLine("no of 1 notes:=" + (cash / 1));
                    cash = cash % 1;

                }
            }
        }
        static void Main(string[] args)
        {
            MachineATM obj = new MachineATM();
            obj.CalculateNotes();
        }
    }
}

