using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.SealedKeyword
{
    class Flower
    {
        
        public virtual void MakeDecoration()
        {
            Console.WriteLine("Flower is used for decoration");
        }

    }

    class Rose : Flower//can nit inherit seals class
    {
        public  override void MakeDecoration()
        {
            // base.MakeDecoration();
            Console.WriteLine("Rose is used for decoration");
        }
    }
    class RedRose : Rose
    {
        public override void MakeDecoration()
        {
            //base.MakeDecoration()
            Console.WriteLine("Red Rose is used for decoration");
        }
    }
    class SealedDemo
    {
        static void Main(string[] args)
        {
            Flower f = new Rose();
            f.MakeDecoration();

            Rose r = new RedRose();
            r.MakeDecoration();
        }
    }
}

