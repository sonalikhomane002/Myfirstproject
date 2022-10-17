using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPsdemo
{
    class Shopping
    {
        public string p_name;
        public int p_quantity;
        public int p_size;
        public int p_price;


        public void Accept_detail(string name, int quantity, int size, int price)
        {
            p_name = name;
            p_quantity = quantity;
            p_size = size;
            p_price = price;



        }
        public void Calculate()
            {
            if(p_quantity>0)
            {
                Console.WriteLine("p_quantity"+p_quantity);

            }
            else
            {
                Console.WriteLine("error message");
            }

        }
        public void Display()
        {
            Console.WriteLine("p_name="+p_name+"p_quantity="+p_quantity+"p_size="+p_size+"p_price"+p_price);

        }
        static void Main(string[] args)
        {
            Shopping shopping = new Shopping();
            shopping.Accept_detail("kiran", 2, 35, 4000);
            shopping.Display();

        }
    }
}
