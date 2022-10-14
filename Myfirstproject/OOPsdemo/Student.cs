using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPsdemo
{
    class Student
    {
        public int s_id;
        public string s_name;
        public int sub1, sub2, sub3;
        public int Total;
        public float percentage;
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.s_id = 101;
            s1.s_name ="Sapna";
            s1.sub1 = 78;
            s1.sub2 = 67;
            s1.sub3 = 51;

            s1.Total = s1.sub1 + s1.sub2 + s1.sub3;
            s1.percentage = (float)((s1.Total / 300f) * 100);
            Console.WriteLine(s1.s_id+" "+s1.s_name);
            Console.WriteLine(s1.percentage);


        }
    }
}
