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
    //task 
   
    class Student
    {
        public int id;
        public string name;

        public Student(int id,string name)
        {
            this.id = id;
            this.name = name;
        }
        public List<int> marks = new List<int>();

    }
    
    class CustomListDemo4
    {
        static void Main(string[] args)
        {
            List<Student> sl = new List<Student>();
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Enter the Student ID  =");
                int sid = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Student Name =");
                string sname = Console.ReadLine();
                Student s = new Student(sid, sname);
                for (int j = 1; j <= 4; j++)
                {
                    Console.WriteLine("Enter the marks m" + i + 1);
                    int m1 = int.Parse(Console.ReadLine());
                    s.marks.Add(m1);

                }
                sl.Add(s);
            }

                Console.WriteLine(".........................");
                foreach (var student in sl)
                {
                    Console.WriteLine(student.id + " " + student.name + " ");
                   foreach (int m in student.marks)
                    {
                        Console.WriteLine(m);
                    }
               
                }

        }
    }




}
