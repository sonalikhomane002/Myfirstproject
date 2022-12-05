using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Constructor
{
    class StaticVariable
    {
        static int no;
        int x;

        public void GetNo()
        {
            Console.WriteLine("static value is="+no);
        }
        public void PutData(int n)
        {
            x = no;
            no++;

        }
        public void GetData()
        {
            Console.WriteLine("instance variable x="+x);
        }
        static void Main(string[] args)
        {
            StaticVariable d1 = new StaticVariable();
            StaticVariable d2 = new StaticVariable();
            StaticVariable d3 = new StaticVariable();

            d1.GetNo();
            d2.GetNo();
            d3.GetNo();

            d1.PutData(100);
            d2.PutData(200);
            d3.PutData(300);

            d1.GetNo();
            d2.GetNo();
            d3.GetNo();

            d1.GetData();
            d2.GetData();
            d3.GetData();






        }
    }
}
