using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPsdemo
{
    class StudentC
    {
        int rollNo;
        string name;
        int marks;

        public StudentC()
        {
            Console.WriteLine("student is initialized");
            rollNo = 0;
            name = "dummy";
            marks = 0;

        }
        public void display()
        {
            Console.WriteLine("Roll no="+rollNo);
            Console.WriteLine("Name="+name);
            Console.WriteLine("Marks="+marks);
        }
        static void Main(string[] args)
        {
            StudentC studentC = new StudentC();
            studentC.display();
            Console.ReadKey();
        }
    }
}
