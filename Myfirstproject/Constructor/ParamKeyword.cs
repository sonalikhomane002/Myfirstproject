using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Constructor
{
    class ParamKeyword
    {
        public static void Add(params float[]nos)
        {
            
            float sum = 0.0f;
            foreach (float n in nos)
                sum = sum + n;
            float Average = sum / nos.Length;
            Console.WriteLine("Average is"+Average);

            Console.WriteLine("Addition of"+nos.Length+"parametr is"+sum);
        }
        public static void AddName(params string[] names)
        {
            string s = "";
            foreach (string str in names)
                s = s + str;
            Console.WriteLine("concatinated string is"+s);
        }

        static void Main(string[] args)
        {
            //Add();
             Add(2.3f, 3.1f, 1.2f, 2.6f);
            //AddName("Hello");
            //AddName("Hello", "Good", "Morning");


        }
    }
}
