using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Constructor
{
    class Course
    {
        private int id;
        private string name;
        private double fees;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Fees
        {
            get { return fees; }
            set { fees = value; }
        }

        static void Main(string[] args)
        {
            Course c1 = new Course();
            c1.id = 1;
            c1.name = "C #";
            c1.fees = 20000;

            Console.WriteLine($"id{c1.Id}{c1.Name}{c1.Fees}");
            Course c2 = new Course { Id = 2, Name = "java", Fees = 20000 };
            Console.WriteLine($"Id{c2.Id}{c2.Name}{c2.Fees}");
        }
    }
}
