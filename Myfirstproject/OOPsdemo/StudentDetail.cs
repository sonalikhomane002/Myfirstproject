using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPsdemo
{
    class StudentDetail
    {
        public int s_id;
        public string s_name;
        public int s_m1;
        public int s_m2;
        public int s_m3;
        public double s_Percentage;

        public void Accept_value(int id, string name, int m1, int m2, int m3)
        {
            s_id = id;
            s_name = name;
            s_m1 = m1;
            s_m2 = m2;
            s_m3 = m3;
        }

        public double calcutePercentage()
        {
            double total = s_m1 + s_m2 + s_m3;
            double s_percentage = total / 300 * 100;
            return s_percentage;

        }
        public void Display()
        {
            Console.WriteLine("student id= "+s_id+"\n"+"student name= "+s_name+"\n"+"marks m1="+s_m1+"\n"+"marks m2="+s_m2+"\n"+"marks m3="+s_m3);
            
           
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
