using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Constructor
{
    //Access modifier example
    internal class Studento
    {
        private int rollno;
        public string name;

        public Studento(int rollno, string name)
        {
            this.rollno = rollno;
            this.name = name;

        }
        public void Display()
        {
            Console.WriteLine("Roll no=" + rollno);
            Console.WriteLine("Name=" + name);
        }
    }
        internal class Program
        {
            static void Main(string[] args)
            {
                Studento stud1 = new Studento(1, "sonali");
                Studento stud2 = new Studento(2, "sapna");
                Studento stud3 = new Studento(3, "priya");
                stud1.Display();
                stud2.Display();
                stud3.Display();
                //stud3.rollno = 3;  it is private member variable
            }

        }
    
}
