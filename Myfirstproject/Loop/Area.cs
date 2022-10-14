using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loop
{
    class Area
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a.area of Triangle\nb.area of Rectangle\nc.area of square\nd.area of circle");
            Console.WriteLine("enter the choice");
            char choice = Convert.ToChar(Console.ReadLine());

            switch (choice)
            {
                case 'a':
                    Console.Write("enter the base:");
                    double Base = Convert.ToDouble(Console.ReadLine());
                    Console.Write("enter the Height:");
                    double Height = Convert.ToDouble(Console.ReadLine());

                    double Area = (Base * Height) / 2;
                    Console.Write("area of a triangle = " + Area);
                    break;

                case'b':
                    
                    Console.WriteLine("enter the length of a rectangle: ");
                    int Length = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter the breadth of a rectangle: ");
                    int Breadth = Convert.ToInt32(Console.ReadLine());
                    double area  = Length * Breadth;
                    Console.WriteLine(area);
                    break;

                case 'c':
                    float PI = 3.14f;
                    Console.Write("Enter Radius: ");
                    double Radious = Convert.ToDouble(Console.ReadLine());
                    double areaofcircle = PI * Radious * Radious;
                    Console.WriteLine("Area of circle: " + areaofcircle);
                    break;

                case 'd':
                    Console.WriteLine("Enter the Side of Square: ");
                    int Side = Convert.ToInt32(Console.ReadLine());
                    int Areaofsquare = Side * Side;
                    Console.WriteLine(Areaofsquare);
                    break;
                default:
                    Console.WriteLine("invalid choice");
                    break;

            }
        }
    }
}
