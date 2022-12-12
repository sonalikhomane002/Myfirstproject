using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.AbstractEx
{
    abstract class Student2
    {
        public abstract void ShowStudent();
        public void DisplayMarks()
        {
            Console.WriteLine("Student Got firstclass ");
        }
    }
    class Person : Student2
    {
        public override void ShowStudent()
        {
            Console.WriteLine("Hi this is student Info.......");
        }
    }
    class AbstractClassDemo
    {
        static void Main(string[] args)
        {
            Student2 s = new Person();
            s.ShowStudent();
            s.DisplayMarks();
        }
    }
}
