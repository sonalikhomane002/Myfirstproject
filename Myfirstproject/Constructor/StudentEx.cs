using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Constructor
{
    // readonly example 
    class StudentEx
    {
        readonly int rollno;
        public string name;

        public StudentEx(int rollno,string name)
        {
            this.rollno = rollno;
            this.name = name;

        }
        public void Display()
        {
            Console.WriteLine("Roll no="+rollno);
            Console.WriteLine("Name="+name);
        }
        static void Main(string[] args)
        {
            StudentEx stud1 = new StudentEx(1, "sonali");
            StudentEx stud2 = new StudentEx(2, "sapna");
            StudentEx stud3 = new StudentEx(3, "priya");
            stud1.Display();
            stud2.Display();
            stud3.Display();

           // stud3.rollno=3  will cause compile time error






        }

    }
    
}
