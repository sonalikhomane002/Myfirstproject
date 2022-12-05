using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPsdemo
{
    class PercentageOfStudent
    {
        
        public float Percentage;

        public float CalculatePercentage(int m1,int m2,int m3,int m4,int m5)
        {
            Percentage = (m1 + m2 + m3 + m4 + m5) / 500f * 100;
            return Percentage;
        }
        public string  CalculateGrade(float percentage)
        {
            if(percentage>=90)
            {
                return "A";
            }
            else if(percentage>=80)
            {
                return "B";
            }
            else if(percentage>=70)
            {
                return "C";

            }
            else if(percentage>=60)
            {
                return "D";

            }
            else if(percentage<50)
            {
                return "E";

            }
            else
            {
                return "fail";
            }
        }
        static void Main(string[] args)
        {
            PercentageOfStudent percentageOfStudent = new PercentageOfStudent();
            float percentage = percentageOfStudent.CalculatePercentage(66, 78, 98, 45, 67);
            Console.WriteLine(percentage);
           string Grade= percentageOfStudent.CalculateGrade(percentage);
            Console.WriteLine(Grade);
        }
    }
}
