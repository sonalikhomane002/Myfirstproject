using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Constructor
{
    class Student2
    {
        int id;
        string name;
        int marks;
       public Student2()//default constructor
        {
            id = 0;
           name = "";
            marks = 0;
        }
        public Student2(int id, string name, int marks):this()
        {
            this.id = id;
            this.name = name;
            this.marks = marks;
        }
        public void display()
        {
            Console.WriteLine(id + "\t" + name + "\t" + marks);
        }
        static void Main(string[] args)
        {
            Student2[] stud = new Student2[3];
            for (int i = 0; i < stud.Length; i++)
            {

                Console.WriteLine("Enter Id := ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Name := ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Marks := ");
                int marks = int.Parse(Console.ReadLine());

                stud[i] = new Student2(id, name, marks);
            }
            Console.WriteLine("Id\tName\tMarks");
            foreach (Student2 s in stud)
            {
                s.display();

            }

            Console.ReadKey();
        }
    }
}

