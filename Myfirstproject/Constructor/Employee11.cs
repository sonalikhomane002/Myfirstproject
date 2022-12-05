using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Constructor
{
    class Employee11
    {
        private int id;
        private string name;
        private double salary;

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
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        static void Main(string[] args)
        {
            Employee11 e1 = new Employee11();
            e1.id = 1;
            e1.name = "abc";
            e1.salary = 20000;

            Console.WriteLine($"id{e1.Id}{e1.Name}{e1.salary}");
            Employee11 e2=new Employee11 { Id = 2, Name = "sonali", salary = 20000 };
            Console.WriteLine($"Id{e2.Id}{e2.Name}{e2.salary}");
        }
    }
}
