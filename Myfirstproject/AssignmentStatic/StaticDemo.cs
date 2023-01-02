using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.AssignmentStatic
{
    class StaticDemo
    {
        static int x = 0;

        StaticDemo()
        {
            x++;
            Console.WriteLine(x);
        }
        static void Main(string[] args)
        {
            StaticDemo d = new StaticDemo();
            StaticDemo d1 = new StaticDemo();
        }

    }
    class StaticDemo2
    {
        int x = 10;
        static int y = 20;

        public void show()
        {
            Console.WriteLine(x + " " + y);
        }
        public static void Display()
        {
            StaticDemo2 obj = new StaticDemo2();
            Console.WriteLine(obj.x + " " + y);
        }
        static void Main(string[] args)
        {
            StaticDemo2 d = new StaticDemo2();
            d.show();
            StaticDemo2.Display();
        }
    }
    class staticDemoTask
    {
        public static int calculation(int x, int y)
        {
            int val = x * y;
            return val;
        }
        static void Main(string[] args)
        {
            // Console.WriteLine(calculation(12, 12));
            int res = staticDemoTask.calculation(5, 2);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
    class Car
    {
        static string model = "we33";
        static int totalcarsold = 23;

        static void Main(string[] args)
        {
            Console.WriteLine("model is " + Car.model);
            Console.WriteLine("totalcarsold " + Car.totalcarsold);
            Car.model = "qw234";
            Console.WriteLine("model is " + Car.model);

            Car car1 = new Car();
            // car1. model = "qwrty456"; cannot aceess with instance of car

            Car car2 = new Car();



        }

    }
    class Student
    {
        public string studentName;
        static string schoolName = "Genius School";
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.studentName = "Sapna";
            Console.WriteLine("Name =" + s1.studentName);//call instance variable
            Console.WriteLine("School Name=" + Student.schoolName);//call static variable

        }
    }
    //5.	See if you can overload static method, by using static keyword for
    //2nd overloaded method and without using static keyword.
    class Program
    {

        public static void Sum(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("The sum is: " + c);
        }

        public void Sum(float a, float b)
        {
            float c = a + b;
            Console.WriteLine("The sum is: " + c);
        }

        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.Sum(12.3f, 2.3f);
            Program.Sum(12, 3);



        }

    }
    //6.See if you can override static method.
    public class Parent
    {

        string name = "Sapna";
        public virtual void showdata()
        {
            Console.WriteLine(" Name=: " + name);
        }
    }


    class Child : Parent
    {


        string s = " Software Engineer";


        public override void showdata()
        {
            base.showdata();

            Console.WriteLine("Position=" + s);
        }
    }

    class Demo
    {

        static void Main()
        {
            Child c = new Child();
            c.showdata();

        }

    }
    //7.WAP to check whether you can inherit static variable of Parent class in Child class

    class A
    {
        public static int num = 20;
        public static void Display()
        {
            Console.WriteLine("Static Method");
        }
    }

    class B : A
    {
        public void Display1()
        {

        }

    }
    class Demo1
    {
        public static void Main(string[] args)
        {

            B.Display();

            Console.WriteLine(B.num);
        }
    }
    //1.Write a method to accept variable no of integers.
    //Method should find sum of all the integers and display the result.
    class Program4
    {


        public static int Sumval(params int[] num)
        {
            int res = 0;


            foreach (int j in num)
            {
                res += j;
            }
            return res;
        }

        static void Main(string[] args)
        {

            int x = Sumval(21, 26, 16, 5);
            Console.WriteLine(x);
        }
    }
    class Program45
    {
        void Display(int a)
        {
            Console.WriteLine("Number: " + a);
        }


        void Display(int a, int b)
        {
            Console.WriteLine("Number is: " + a + " and " + b);
        }
        static void Main(string[] args)
        {

            Program45 p1 = new Program45();
            p1.Display(100);
            p1.Display(100, 200);
            Console.ReadLine();
        }

    }
    //5.	Write a  program to show the use of method overriding.
    class Class1
    {

        public virtual void Show()
        {

            Console.WriteLine("Parent Class Show Method");
        }
    }
    class Class2 : Class1
    {

        public override void Show()
        {

            Console.WriteLine("Child Class Show Method");
        }
    }

    class Programp
    {
        static void Main(string[] args)
        {
            Class1 obj1 = new Class2();
            obj1.Show();
            Class2 obj2 = new Class2();
            obj2.Show();
            Console.ReadKey();
        }
    }
    //6.WAP to show all the use of ‘this’ keyword.
    class UseofThisKeyword
    {
        int a, b, sum;

        public UseofThisKeyword()
        {
            a = 0;
            b = 0;
            sum = a + b;
        }
        public UseofThisKeyword(int a)
        {
            Console.WriteLine("Single parameterized constructor called");
            this.a = a;
            this.b = a;
            sum = a + b;


        }
        public UseofThisKeyword(int a, int b) : this(a)
        {
            this.a = a;
            this.b = b;

        }
        public void putinfo()
        {
            Console.WriteLine("Addition is" + sum);
        }
        static void Main(string[] args)
        {
            UseofThisKeyword obj = new UseofThisKeyword();
            obj.putinfo();
            obj = new UseofThisKeyword(3);
            obj.putinfo();
            obj = new UseofThisKeyword(10);
            obj.putinfo();

        }
    }

    class Test
    {
        public static void Display()
        {
            Console.WriteLine("Hello");
        }
    }
    class Program7
    {
        static void Main(string[] args)
        {
            Test.Display();
        }
    }



}
