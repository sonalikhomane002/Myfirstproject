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

    class Rose : Flower//can not inherit seals class
    {
        public override void MakeDecoration()
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
}

