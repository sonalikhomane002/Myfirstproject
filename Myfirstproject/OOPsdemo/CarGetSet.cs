using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPsdemo
{
    class CarGetSet
    {
        int modelNo;
        string name;
        int price;
        string color;

        public int ModelNo
        {
            set
            {
                modelNo = value;
            }
            get
            {
                return modelNo;
            }
        }
        public String Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public int Price
        {
            set
            {
                price = value;
            }
            get
            {
                return price;
            }
        }
        public string Color
        {
            set
            {
                color = value;

            }
            get
            {
                return color;
            }


        }


    }

    class CarGetSetTest
    {
        static void Main(String[] args)
        {
            CarGetSet carGet = new CarGetSet();
            carGet.ModelNo = 101;
            carGet.Name = "Breeza";
            carGet.Price = 1400000;
            carGet.Color = "White";

            Console.WriteLine(carGet.ModelNo);
            Console.WriteLine(carGet.Name);
            Console.WriteLine(carGet.Price);
            Console.WriteLine(carGet.Color);


        }
    }
}
