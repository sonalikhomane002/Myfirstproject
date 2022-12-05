using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Constructor
{
    class Student
    {
        int id;
        string name;
        int marks;

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
        public int Marks
        {
            get { return Marks; }
            set { marks = value; }
        }
        static void Main(string[] args)
        {
            Student[] Stud = new Student[3];
            for (int i = 0; i < Stud.Length; i++)
            {
                Stud[i] = new Student();
                Console.WriteLine("enter id=");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("enter Name=");
                string Name = Console.ReadLine();
                Console.WriteLine("enter marks=");
                int marks = int.Parse(Console.ReadLine());



                Stud[i].Id = id;
                Stud[i].Name = Name;
                Stud[i].Marks = marks;


            }
            Console.WriteLine("Id\tName\tMarks");
            for (int i = 0; i < Stud.Length; i++)
            {
                Console.WriteLine(Stud[i].Id + "\t" + Stud[i].Name + "\t" + Stud[i].Marks);
            }
            Console.ReadLine();
        }
    }

}
