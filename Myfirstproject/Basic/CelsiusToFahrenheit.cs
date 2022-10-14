using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Basic
{
    class CelsiusToFahrenheit
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Temperature in celsius is: " );
            float celsius = float.Parse(Console.ReadLine());
            float fahrenheit = ((celsius * 9) / 5) + 32;
            Console.WriteLine("Temperature in Fahrenheit is: " + fahrenheit);

        }
    }
    class FahrenheitToCelsius
    {
        static void Main(string[]args)
        {
            
            Console.WriteLine("Temperature in Fahrenheit is:");
            double Fahrenheit = double.Parse(Console.ReadLine());
            double Celsius = (Fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Temperature in celsius is:" + Celsius);
        }
    }


}
