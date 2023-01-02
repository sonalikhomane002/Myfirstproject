using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StructureDemo
{
    struct Mystruct
    {
         int x;
         int y;

       /* public Mystruct(int x,int y)
        {
            this.x = x;
            this.y = y;
        }*/
      /* public int X
        {
            set;
            get;
        }
        public int Y
        {
            set;
            get;
        }*/
      public void MyData()
        {
            Console.WriteLine("this is MyData");
        }
    }
    class Demo
    {
        static void Main(string[] args)
        {
            // Mystruct s = new Mystruct(400,200);
            Mystruct s = new Mystruct();
            s.MyData();
          //  s.X = 11;
           // s.Y = 89;
            //Console.WriteLine(s.X);
            //Console.WriteLine(s.Y);
        }
    }

}
