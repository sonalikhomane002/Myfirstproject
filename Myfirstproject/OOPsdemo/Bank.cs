using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPsdemo
{
    class Bank
    {

        int bal;

        public int GetBalance()
        {
            return bal;
        }
        public void Withdraw(int amt)
        {
            bal = bal - amt;
        }
        public void Deposit(int amt)
        {
            bal = bal + amt;
        }
        static void Main(string[] args)
        {
            Bank obj = new Bank();
            obj.Deposit(3000);
            Console.WriteLine("current balance after 3000 deposit is="+obj.GetBalance());
            obj.Deposit(2000);
            Console.WriteLine("current balance after 2000 deposit is=" + obj.GetBalance());
            obj.Withdraw(4000);
            Console.WriteLine("current balance after withdraw 4000  is=" + obj.GetBalance());

        }




    }

}
