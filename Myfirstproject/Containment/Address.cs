using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Containment
{
    class Address
    {
        int pincode;
        string city;


        public Address(int pincode,string city)
        {
            this.pincode = pincode;
            this.city = city;
        }
        public void DisplayAddress()
        {
            Console.WriteLine(pincode+" "+city);
        }
    }
    class Person
    {
        int id;
        string name;
        Address adr;

        public Person(int id,string name,Address adr)
        {
            this.id = id;
            this.name = name;
            this.adr = adr;

        }
        public void DisplayPerson()
        {
            Console.WriteLine(id+" "+name+" ");
            adr.DisplayAddress();
        }
        static void Main(string[] args)
        {
            Person p = new Person(1, "vikas", new Address(413130, "pune"));
            p.DisplayPerson();
        }
    }
    class Department
    {
        int deptId;
        string deptName;

        public Department(int deptId,string deptName)
        {
            this.deptId = deptId;
            this.deptName = deptName;
        }
        public void DisplayDepartment()
        {
            Console.WriteLine(deptId+" "+deptName);
        }
    }
    class Employee
    {
        int empId;
        string empName;
        Department dept;

        public Employee(int empId,string empName,Department dept)
        {
            this.empId = empId;
            this.empName = empName;
            this.dept = dept;
        }
        public void DisplayEmployee()
        {
            Console.WriteLine(empId + " " + empName + " ");
            dept.DisplayDepartment();
        }
        static void Main(string[] args)
        {
            Employee e = new Employee(101, "Dhruv",new Department(1, "Mechanical"));
            e.DisplayEmployee();
        }
    }

    

    
}
