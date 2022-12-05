using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPsdemo
{
    class toggleCase
    {
        public void toggle()
        {
            Console.WriteLine("enter the character");
            int ch;
             ch = Convert.ToChar(Console.ReadLine());

            if (ch >= 65 && ch <= 90)
                ch = ch + 32;

            else
                ch = ch - 32;
            Console.WriteLine("enter chracter is:= "+(char)ch);

            
        }

        static void Main(string[] args)
        {
            toggleCase obj = new toggleCase();
            obj.toggle();

        }
    }
}
         
    

