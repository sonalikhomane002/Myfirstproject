using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPsdemo
{
    class ElectricityCunsumption
    {
      

        public void calculateElectricityBill()
        {
            int units_Consumed;
            double bill=0;

            Console.WriteLine("enter units consumed from customer");
            units_Consumed = int.Parse(Console.ReadLine());

            if (units_Consumed <= 50)
                bill = units_Consumed * 0.50;
            else
                if (units_Consumed <= 150)
                bill = (50 * 0.50) + (units_Consumed - 50) * 0.75;
            else
                if (units_Consumed <= 250)
                bill = (50 * 0.50) + ((units_Consumed - 50) * 0.75) + (units_Consumed - 150) * 1.20;
            else
                if (units_Consumed >= 250)
                bill = units_Consumed * 1.50;
            bill = bill + (bill * 0.2);
            Console.WriteLine(bill);

            
        }
        static void Main(string[] args)
        {
            ElectricityCunsumption electricityCunsumption = new ElectricityCunsumption();
            electricityCunsumption.calculateElectricityBill();
        }
    }
}
