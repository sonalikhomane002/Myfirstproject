using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.MethodOverriding
{
    class Parent
    {
        public virtual void Show()
        {
            Console.WriteLine("Parent");
        }
    }
    class Child : Parent
    {
        public override void Show()
        {
            Console.WriteLine("Child");
        }
    }
    class OverridingDemo
    {
        static void Main(string[] args)
        {
            /* Child c = new Child();
             c.Show();*/

            Parent p = new Child();
            p.Show();
        }
    }
    //example2
    class parent1
    {
        public virtual void Show()
        {
            Console.WriteLine("Parent");
        }
    }
    class Child1 : Parent
    {
        /*  public override void Show()
          {
              Console.WriteLine("Child");
              //base.Show();
          }
      }*/
        public new void Show()
        {
            base.Show();
            Console.WriteLine("child");
        }
        class OverridebaseDemo
        {
            static void Main(string[] args)
            {
                /* Child c = new Child();
                 c.Show();*/

                Parent p = new Child();
                p.Show();
            }
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

    class Program
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
}
