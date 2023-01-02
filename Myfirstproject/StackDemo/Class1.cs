using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StackDemo
{
    class Class1
    {
        static void Main(string[] args)
        {
            Stack<string> s = new Stack<string>();
            s.Push("Red");
            s.Push("green");
            s.Push("blue");

            foreach (var st in s)
            {
                Console.WriteLine(st);
            }
            Console.WriteLine(".........................");
            Console.WriteLine(s.Contains("green"));
            Console.WriteLine(".............PEEK....................");
            Console.WriteLine(s.Peek());
            Console.WriteLine("............................");
            foreach (var st in s)
            {
                Console.WriteLine(st);
            }
            Console.WriteLine("........POP.................");

            s.Pop();

            Console.WriteLine("..........................");
            foreach (var st in s)
            {
                Console.WriteLine(st);
            }
        }
    }
    class Employee
    {
        public int id;
        public string name;
        public int salary;

        public Employee(int id, string name, int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;

        }
        /*public void Dispaly()
        {
            Console.WriteLine("emp id="+id+"name "+name+"salary"+salary);
        }*/
        static void Main(string[] args)
        {
            Stack<Employee> empStack = new Stack<Employee>();

            empStack.Push(new Employee(1, "anuj", 20000));
            empStack.Push(new Employee(2, "Priya", 45000));
            empStack.Push(new Employee(3, "om", 55000));
            empStack.Push(new Employee(4, "Amol", 25000));
            empStack.Push(new Employee(5, "Aryan", 15000));

            foreach (Employee s in empStack)
            {

                Console.WriteLine(s.id + " " + s.name + " " + s.salary);

            }
            Console.WriteLine(".................");
            Employee emp = empStack.Peek();

            Console.WriteLine("TopMost Employee \n Name = " + emp.name + " Id = " + emp.id + " Emp Salary = " + emp.salary);



        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> country = new Stack<string>();

        }
    }



}

