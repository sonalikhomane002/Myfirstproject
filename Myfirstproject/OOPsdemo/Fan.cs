using System;


namespace Myfirstproject.OOPsdemo
{
    class Fan
    {

        internal string name = "Bajaj";
        protected int securityCode = 2020;
        private int price = 5000;
        public string color = "white";



        private int getPrice()
        {
            return price;

        }

        internal string getName()
        {
            return name;
        }
        protected int getSecurityId()
        {
            return securityCode;
        }

        public string getColor()
        {
            return color;
        }

     

    }
    class TableFan:Fan
    {
        bool isCovered ;
        bool isRoteted;

        static void Main(string[] args)
        {
            Fan fan = new Fan();
            fan.color = "white";
           // fan.price = 10000;
            fan.name = "Bajaj";
            //fan.securityCode = 2020;
            fan.name = "Bajaj";
            Console.WriteLine(fan.name);
            Console.WriteLine(fan.color);
         

        }
    }
     

            
        
         


    
}
