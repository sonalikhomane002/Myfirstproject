using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPsdemo
{
    class Studentdemo
    {
        int rollno;
        string name;
        int marks;

        public Studentdemo()
        {
            Console.WriteLine("This is Default Constructor");
        }
        public Studentdemo(int rollno,string name)
        {
            Console.WriteLine("\nconstructor with 2 parameters");
            this.rollno = rollno;
            this.name = name;

        }
        public Studentdemo(int rollno,string name,int marks )
        {
            Console.WriteLine("\n This constructor with 3 parameters");
            this.rollno = rollno;
            this.name = name;
            this.marks = marks;
        }
        public void display()
        {
            Console.WriteLine("Roll no=" + rollno);
            Console.WriteLine("Name=" + name);
            Console.WriteLine("Marks=" + marks);
        }
        static void Main(string[] args)
        {
            Studentdemo studentdemo = new Studentdemo();
            studentdemo.display();

            Studentdemo studentdemo1 = new Studentdemo(1,"Sapna");
            studentdemo1.display();

            Studentdemo studentdemo2 = new Studentdemo(2,"Ashish",78);
            studentdemo2.display();

        }



          
            

        
    }
}
