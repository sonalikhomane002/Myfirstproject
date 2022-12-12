using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Inheritance
{
    //single inheritance Example1
    class Animal
    {
        public int legs = 4;
    }
    class Dog : Animal
    {
        public void Show()
        {
            Console.WriteLine("Dog has " + legs + "  legs");
        }
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.Show();
        }
    }
    // task single inheritance example2
    class Father
    {
        public int noOfhouse = 2;
    }
    class Son : Father
    {
        public void show()
        {
            Console.WriteLine("number of house  of son" + noOfhouse);
        }

        static void Main(string[] args)
        {
            Son s = new Son();
            s.show();

        }
    }
    //  multilevel inheritance example
    class Mobile
    {
        public string Ramsize = "4Gb";
        public void ShowMobileData()
        {
            Console.WriteLine("Ramsize=" + Ramsize);
        }

    }
    class Apple : Mobile
    {
        public void show()
        {
            Console.WriteLine(Ramsize);
        }
    }
    class Iphone : Apple
    {
        public void ChangeSize()
        {
            Ramsize = "16GB";
        }
        public void DisplayData()
        {
            Console.WriteLine("Iphone RamSize=" + Ramsize);
        }
    }
    class MultievelDemo
    {
        static void Main(string[] args)
        {

            Iphone obj = new Iphone();
            obj.ShowMobileData();
            obj.ChangeSize();
            obj.show();
            obj.DisplayData();

        }

    }
    //Task Multilevel Inheritance example
    class Person
    {

        public void show()
        {
            Console.WriteLine("Student inheriting properties from Person");
        }
    }
    class Student : Person
    {
        public void show1()
        {
            Console.WriteLine("I am a Student who belongs to Person class");
        }
    }
    class EngineeringStudent : Student
    {

        public void show2()
        {
            Console.WriteLine("Engineering Student inheriting properties from Student");
        }
    }

    public class MultiLevelDemo
    {
        static void Main(string[] args)
        {
            EngineeringStudent obj = new EngineeringStudent();
            obj.show();
            obj.show1();
            obj.show2();

        }
    }
    //Hierarchical Inheritance Demo
    class Vechicle
    {
        public int Wheels;

        public void Run()
        {
            Console.WriteLine("vechicle is running");
        }
    }
    class Car : Vechicle
    {
        public void showCar()
        {
            Wheels = 4;
            Console.WriteLine("car is running on=" + Wheels + "wheels");
        }
    }
    class Truck : Vechicle
    {
        public void showTruck()
        {
            Wheels = 8;
            Console.WriteLine("Truck is running on =" + Wheels + "wheels");
        }
    }
    class HierarchicalDemo
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.Run();
            c.showCar();
            Truck t = new Truck();
            t.Run();
            t.showTruck();
        }
    }
    //Task Hierarchical Example
    class Animal1
    {
        public void info()
        {
            Console.WriteLine(" This is the Animal");
        }
    }


    class Dog1 : Animal1
    {
        public void bark()
        {
            Console.WriteLine("This is the Dog");
        }
    }

    class Cat : Animal1
    {
        public void meow()
        {
            Console.WriteLine("This is the cat");
        }
    }
    class Demo
    {
        static void Main(string[] args)
        {
            Dog1 d1 = new Dog1();
            d1.bark();
            d1.info();
            Cat c = new Cat();
            c.info();
            c.meow();

        }

    }
    //baseDemo
    class Laptop
    {
        public string ram = "4Gb";

    }
    class Dell : Laptop
    {
        public string ram = "16GB";
        public void show()
        {
            Console.WriteLine(ram+" "+base.ram);
        }
    }
    class BaseDemo
    {
        static void Main(string[] args)
        {
            Dell d = new Dell();
            d.show();
        }
    }

}















