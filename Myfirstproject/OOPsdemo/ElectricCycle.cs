using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPsdemo
{
    class ElectricCycle : Cycle
    {
        float batteryPrice;
        int batteryBackup;

        static void Main(string[] args)
        {
            Cycle cycle = new Cycle();
            //cycle.id = 1001; not accessible because this is private property of class
            cycle.name = "R for Rabbit";
            cycle.price = 8000;
           // Console.WriteLine(cycle.checkGeared(1001));
            Cycle obj1 =  cycle.GetCycleDetails();
            Console.WriteLine(obj1.name+" "+ obj1.price + " ");
            // cycle.getPrice(1001); Not accessible because this is the protected method of
            //Cycle class. so we can not access it out side of cycle class using cycle instance
            // we need to use Electric cycle instance to access getPrice method.


            // cycle.getName(); Not accessible due to private method of cycle class
            // we can access private propeties and method only inside the class.
            // From out side class we can not access them.

            //cycle.isGeared = true; not accessible with cycle instance from outside of class
            //need to access with Electriccycle instance
            ElectricCycle electricCycle = new ElectricCycle();
            electricCycle.isGeared = true;
          //  Console.WriteLine(electricCycle.getPrice(1001));
        }
    }


}
