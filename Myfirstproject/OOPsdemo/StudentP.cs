using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPsdemo
{
    class StudentP
    {

        int rollNo;
        string name;
        int marks;

        public StudentP(int rollNo,string name,int marks)
        {
            
            this.rollNo = rollNo;
            this.name = name;
            this.marks = marks;

        }
        public void display()
        {
            Console.WriteLine("Roll no=" + rollNo);
            Console.WriteLine("Name=" + name);
            Console.WriteLine("Marks=" + marks);
        }
        public void compare(StudentP studentC1 )
        {
            if (marks > studentC1.marks)
                this.display();
            else
                studentC1.display();

        }
        static void Main(string[] args)
        {
            StudentP studentC = new StudentP(1,"Sonali",99);
           
            StudentP studentC1 = new StudentP(2, "Dhruv", 77);

            studentC.compare(studentC1);

        }
    }
}
