using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Constructor
{
    class Employee
    {
        public int Id;
        public string Name;
        public float BasicSalary;
        public float Allowences;
        public float AllDeduction;
        private float grossSalary;
        private float netSalary;


        public Employee()
        {
            Id = 100;
            Name = "Vikas";
            BasicSalary = 200;
            Allowences = 100;
            AllDeduction = 20;
        }
        public Employee(int Id, string name, float basicsalary, float allowences, float alldeduction)
        {
            this.Id = Id;
            this.Name = name;
            this.BasicSalary = basicsalary;
            this.Allowences = allowences;
            this.AllDeduction = alldeduction;

        }

        /// <summary>
        /// 
        /// </summary>
        public void Display()
        {
            Console.WriteLine("id=" + this.Id);
            Console.WriteLine("name=" + Name);
            Console.WriteLine("basicsalary=" + BasicSalary);
            Console.WriteLine("allowences=" + Allowences);
            Console.WriteLine("Net Salary =" + this.netSalary);
            Console.WriteLine("Gross Salary =" + this.grossSalary);
        }

        /// <summary>
        /// This method calculate the gross and Net salary
        /// </summary>
        public void CalculateSalary()
        {
            this.grossSalary = BasicSalary + Allowences;
            this.netSalary = grossSalary - AllDeduction;
        }
        static void Main(string[] args)
        {
            Employee obj1 = new Employee();
            obj1.CalculateSalary();
            obj1.Display();
            Employee obj2 = new Employee(1, "sonali", 22000.5f, 2300.4f, 1500.0f);
            obj2.CalculateSalary();
            obj2.Display();


        }
    }
}
