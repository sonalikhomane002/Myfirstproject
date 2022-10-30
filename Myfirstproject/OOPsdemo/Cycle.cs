using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPsdemo
{
    public class Cycle
    {
        private int id=1001;
        internal string name="R for Rabbit";
        protected bool isGeared = true;
        public float price = 5000;

        private string getName() 
        {
            return name;
        }
       
        internal string checkGeared()
        {
            return isGeared ? "Yes" : "Not";
        }

        protected float getPrice()
        {
            return price;
        }

        public Cycle GetCycleDetails()
        {
            Cycle cycle = new Cycle();
            cycle.id = 1001;
            cycle.name = "R For Rabit";
            cycle.isGeared = false;
            cycle.price = 8000.5f;
            return cycle;
        }
    }
}
