using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.DelegatesDemo
{
    class Deldemo5
    {
        public delegate void MyDel(string msg);
        static void CallMethod(MyDel d)
        {
            d.Invoke("welcome to pune.........");
        }
        static void Main(string[]args)
        {
            MyDel del = Test.Method;
            Deldemo5.CallMethod(del);
        }
    }
    class Test
    {
       
            public static void Method(string msg)
            {
                Console.WriteLine("..........."+msg);
            }
        
    }

}
