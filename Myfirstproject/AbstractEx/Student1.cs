using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.AbstractEx
{
     abstract class Student1
     {
        public abstract void Showstudent1();

        public Student1(string name)
        {
            Console.WriteLine("Student" + " " + name);
        }
        public void DisplayMarks()
        {
            Console.WriteLine("Student Got firstclass ");
        }
     }
    class Person1 : Student1
    {
        public Person1() : base("")
        {

        }
        public  void ShowStudent1()
        {
            Console.WriteLine("Hi this is student Info.......");
        }

        public override void Showstudent1()
        {
            throw new NotImplementedException();
        }
    }
    class AbstractBaseclass
    {
        static void Main(string[] args)
        {
            Student1 s = new Person1();
          // s.ShowStudent1();
            s.DisplayMarks();

        }
    }
}
