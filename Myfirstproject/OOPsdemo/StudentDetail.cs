using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPsdemo
{
    class StudentDetail
    {
        public int id;
        public string name;
        public int m1;
        public int m2;
        public int m3;
        public double Percentage;

        public void Accept_value(int id, string name, int m1, int m2, int m3)
        {
           this. id = id;
           this. name = name;
           this.m1 = m1;
            this.m2 = m2;
            this.m3 = m3;
        }

        public double calcutePercentage()
        {
            double total = m1 + m2 + m3;
            double s_percentage = total / 300 * 100;
            return s_percentage;

        }
        public void Display()
        {
            Console.WriteLine("student id= "+id+"\n"+"student name= "+name+"\n"+"marks m1="+m1+"\n"+"marks m2="+m2+"\n"+"marks m3="+m3);
            
           
        }
        static void Main(string[]args)
        {
            StudentDetail studentDetail = new StudentDetail();
            studentDetail.Accept_value(101, "Dhruv", 91, 89, 56);
            studentDetail.Display();
            double percentage=studentDetail.calcutePercentage();
            Console.WriteLine("student percentage= "+percentage);


        }

        
    }
}
