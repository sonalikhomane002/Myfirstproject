using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPsdemo
{
    class EmployeeSalary
    {


        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }


        public void compare(EmployeeSalary e)
        {
            if (Salary > e.Salary)
                display();
            else
                e.display();
        }


        public void display()
        {
            Console.WriteLine("id=" + Id);
            Console.WriteLine("name=" + Name);
            Console.WriteLine("salary" + Salary);

        }
        static void Main(string[] args)
        {
            EmployeeSalary e1 = new EmployeeSalary();
            e1.Id = 101;
            e1.Name = "sonali";
            e1.Salary = 55000;

            EmployeeSalary e2 = new EmployeeSalary();
            e2.Id = 102;
            e2.Name = "Dhruv";
            e2.Salary = 45000;

            e1.compare(e2);

        }




    }
        
    
}
