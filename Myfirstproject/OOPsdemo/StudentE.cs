using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPsdemo
{
    //copy constructor.
    class StudentE
    {
        int id;
        string name;
        int age;

        public StudentE()
        {
            id = 0;
            name="";
            age = 0;


        }
        public StudentE(int id,string name,int age):this(id,name)
        {
            this.id=id;
            this.name = name;
            this.age = age;


        }
        public StudentE(int id,string name)
        {
            this.id = id;
            this.name = name;
            Console.WriteLine("constructor with 2 parameter");
        }
        public StudentE(StudentE s)
        {
            this.id = s.id;
            this.name = s.name;
            this.age = s.age;
        }
        public void display()
        {
            Console.WriteLine("id="+id+"name="+name+"age="+age);
        }
        static void Main(string[] args)
        {
           // StudentE studentE = new StudentE();
            //studentE.display();
            StudentE studentE1 = new StudentE(1,"sonali",76);
            studentE1.display();
            StudentE studentE2 = studentE1;
            studentE2.display();
        }
    }
}
