using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPsdemo
{
    class Box
    {
        public int Height;
        public int  Width;
        public int Length;
        public int Area;
        

        static void Main(string[] args)
        {
        
           Box obj1 = new Box();
            obj1.Height = 4;
            obj1.Width = 2;
            obj1.Length = 5;


            int Area = 2 *(obj1.Length)*( obj1.Width)+ 2 *
                obj1.Length* obj1.Height + 2 * obj1.Width * obj1.Height;
            Console.WriteLine(Area);

            

        }
    }
}
