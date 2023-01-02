using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.DelegatesDemo
{
    public delegate void MyDelegate(string msg);
    class Employee
    {
        public static void MyEmployee(string str)
        {
            Console.WriteLine("hello all" +str);
        }
    }
    class Deldemo
    {
        static void Main(string[] args)
        {
            MyDelegate del = Employee.MyEmployee;
            del("In Tq");
        }
    }

}
