using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPsdemo
{
    class StudentEncap
    {
        int id;
        string name;
        int age;

        public void getInfo(int id,string name,int age)
        {
           this. id = id;
            this.name = name;
           this. age = age;

        }
        public void putInfo()
        {
            Console.WriteLine("Id="+id);
            Console.WriteLine("Name="+name);
            Console.WriteLine("Age="+age);
        }
        static void Main(string[] args)
        {
            StudentEncap obj = new StudentEncap();
            

            obj.getInfo(2,"Dhruv",10);

            obj.putInfo();
        }
    }
}
