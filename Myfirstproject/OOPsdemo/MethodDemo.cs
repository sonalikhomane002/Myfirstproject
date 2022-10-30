using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPsdemo
{
    class MethodDemo
    {
        //no return type no Parameter
        public void ShowDetail()
        {
            Console.WriteLine("C sharp Programming");

        }
        //no return type with Parameter
        public void AcceptDeta(string Name,int Salary)
        {
            Console.WriteLine("name=" +Name+"Salary =" +Salary);
        }
        //return type with no parameter
        public int sum()
        {
            int c = 10 + 20;
            return c;
        }
        //return type with parameter
        public double CalculateArea(int r,double PI)
        {
            return PI * r * r;
        }
        static void Main(string[] args)
        {
            MethodDemo methodDemo = new MethodDemo();
            methodDemo.ShowDetail();
            methodDemo.AcceptDeta("Sonali " , 20000);
            int ans = methodDemo.sum();
            Console.WriteLine("sum="+ans);
            Console.WriteLine(methodDemo.CalculateArea(4,3.14));
            


        }
         
    }
}
