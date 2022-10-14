using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPsdemo
{
    class Car
    {
        public int c_model_no;
        public string c_name;
        public int c_Price;
        public string c_colour;


        static void Main(string[] args)
        {
            Car Car1 = new Car();
            Car1.c_model_no = 101;
            Car1.c_name = "Audi";
            Car1.c_Price = 1200000;
            Car1.c_colour = " White";
            Console.WriteLine(Car1.c_model_no +"  "+ Car1.c_name +"  "+Car1.c_Price +"  "+Car1.c_colour +" ");

            Car Car2 = new Car();
            Car2.c_colour = "Black";
            Car2.c_model_no = 102;
            Car2.c_Price = 150000;
            Car2.c_name = "i20";
            Console.WriteLine(Car2.c_model_no+"  "+Car2.c_name+" "+Car2.c_Price+"  "+Car2.c_colour+" ");

            Car Car3 = new Car();
            Car3.c_model_no = 103;
            Car3.c_name = "Santro";
            Car3.c_Price = 1200000;
            Car3.c_colour = "White";
            Console.WriteLine(Car3.c_model_no+" "+Car3.c_name+" "+Car3.c_Price+" "+Car3.c_colour+"  ");

        }

    }
}
