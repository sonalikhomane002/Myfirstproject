using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.AbstractEx
{
    abstract class Animal
    {
        public abstract void Run();
    }
    abstract class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking.........");
        }
    }

    class BabyDog : Dog
    {
        public override void Run()
        {
            Console.WriteLine("Baby dog is running.........");
        }
    }
    class AbstractOverrideDemo
    {
        static void Main(string[] args)
        {
            Dog d = new BabyDog();
            d.Bark();
            d.Run();
        }

    }
    abstract class Language
    {
        public void Display()
        {
            Console.WriteLine("Non abstract method");
        }
    }
    class Program:Language
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Display();
        }
    }
   
}
