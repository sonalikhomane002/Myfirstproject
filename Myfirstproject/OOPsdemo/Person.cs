using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPsdemo
{
    class Person
    {
        string name;
        int age;

        public string Name
        {
            get { return name; }
            set { name = value; }

        }
        public int Age
        {
            get { return age; }
            set { age = value; }

        }
        public Person compare(Person p)
        {
            if(age>p.age)
            {
                return this;

            }
            else
            {
                return p;
            }
        }
        public void display()
        {
            Console.WriteLine("Name=" +Name+"age" +age);
        }

        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Name = "Sachin";
            p1.Age = 45;

            Person p2 = new Person();
            p2.Name = "Karan";
            p2.Age = 20;

            Person p3 = new Person();
            p3.Name = "om";
            p3.age = 66;
                

            Person p = new Person();
            p = p1.compare(p2);

            Console.WriteLine("elder person is" + p.Name+ "have age" +p.age);
            p = p1.compare(p3);
            Console.WriteLine("elder person is"  + p.Name+ "have age" +p.age);
        }
    }
}
