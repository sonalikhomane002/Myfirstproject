using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPsdemo
{
    class StudentInformation
    {
        int id;
        string name;
        int m1;
        int m2;
        int m3;
        double percentage;
        string grade;


        public void AcceptValue(int id,string name,int m1,int m2,int m3)
        {
           this. id = id;
           this. name = name;
           this. m1 = m1;
           this.m2 = m2;
           this. m3 = m3;
        }
        public double calculatePercentage()
        {
            double total = m1 + m2 + m3;
            double percntage =( total / 300f )* 100f;
            return percntage;
        }
        public string Grade(double percentage)
        {
            if (percentage >= 90)
            {
                return "A";
            }
            else if (percentage >= 80)
            {
                return "B";
            }
            else if (percentage >= 70)
            {
                return "C";

            }
            else if (percentage >= 60)
            {
                return "D";

            }
       
            else
            {
                return "fail";
            }


        }
        
        static void Main(string[] args)
        {
            StudentInformation obj = new StudentInformation();
            obj.AcceptValue(1,"sonali",66,78,99);
            double percentage = obj.calculatePercentage();
            Console.WriteLine(percentage);
            string Grade = obj.Grade(percentage);
            Console.WriteLine(Grade);
        }

        

        
     

    }
}
