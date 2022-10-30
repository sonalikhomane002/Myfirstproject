using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPsdemo
{
    class Time
    {


        public int Hr { get; set; }

        public int Min { get; set; }


        public Time add(Time t1, Time t2)
        {
            Time t = new Time();
            t.Hr = t1.Hr + t2.Hr;
            t.Min = t1.Min + t2.Min;

            if (t.Min >= 60)
            {
                t.Min = t.Min % 60;
                t.Hr++;
            }
            return t;

        }
        public void display()
        {
            Console.WriteLine("time is=" + Hr + "  " + Min);
        }


        static void Main(string[] args)
        {
            Time t1 = new Time();
            t1.Hr = 6;
            t1.Min = 45;



            Time t2 = new Time();
            t2.Hr = 4;
            t2.Min = 35;

            Time t3 = new Time();
            t3 = t3.add(t1, t2);
            t1.display();
            t2.display();
            t3.display();

        }
    }
}







            

         

        



   

