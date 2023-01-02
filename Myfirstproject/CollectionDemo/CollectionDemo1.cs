using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Myfirstproject.CollectionDemos
{
    class CollectionDemo1
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();

            al.Add("Mumbai");
            al.Add(89.5);
            al.Add(99);
            al.Add('h');
            Console.WriteLine(al.Count);
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }
            Console.WriteLine("....................");
            foreach (var x in al)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine(al[1]);

        }
    }

    //Task: even position element from the Array
    class CollectionDemo3
    {
        static void Main(string[] args)
        {

            ArrayList al = new ArrayList()
           {
                5,
                9,
                7,
                5,
                9,
                6

           };
            for (int i = 1; i < al.Count; i += 2)
            {

                Console.WriteLine(al[i]);
            }

        }
    }
    class Task5
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList()
            {
                1,
                "Dhruv",
                "pranali",
                "Priya",
                "Neeta",
                50000,
                850,
                'p',
                'S',
                150
            };

            for (int i = 0; i < al.Count; i+=2)
            {
              
               Console.Write(al[i] + "  ");
               
            }
        }
    }
    class Task2
    {
        //sort the string on basis of string length
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string Array");
            string[] str = new string[5];
            for (int i = 0; i < str.Length; i++)
            {
                str[i] = Console.ReadLine();
            }

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i + 1; j < str.Length; j++)
                {
                    if (str[i].Length > str[j].Length)
                    {
                        string temp = str[i];
                        str[i] = str[j];
                        str[j] = temp;
                    }
                    else if (str[i].Length == str[j].Length)
                    {
                        if (str[i].CompareTo(str[j]) < 1)
                        {
                            string temp = str[i];
                            str[i] = str[j];
                            str[j] = temp;
                        }
                    }
                }
            }

            Console.WriteLine("Sorted Array");
            foreach (string name in str)
            {
                Console.WriteLine(name);
            }
        }
    }

    class CollectionDemo4
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(1);
            al.Add("Satara");
            al.Add('u');
            al.Add(56);
            al.Add(22.44);


            foreach (var x in al)
            {
                Console.WriteLine(x);
            }
            al.Remove('u');
            Console.WriteLine("..................");
            foreach (var x in al)
            {
                Console.WriteLine(x);
            }
            al.RemoveAt(0);
            Console.WriteLine("..............");
            foreach (var x in al)
            {
                Console.WriteLine(x);
            }
            // Console.WriteLine(al.Contains(45));
            ArrayList al2 = new ArrayList();
            al2.AddRange(al);

            // al.RemoveRange(0, 2);
            // Console.WriteLine("..........Range remove..........");
            foreach (var x in al)
            {
                Console.WriteLine(x);
            }
        }
    }
    class CollectionDemo5
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            {
                al.Add("Baramati");
                al.Add(54.55);
                al.Add('t');
                al.Add(4);

            }
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }

            al.Add(78);
            Console.WriteLine("..........");
            foreach (var x in al)
            {
                Console.WriteLine(x);
            }

        }
    }
    class CollectionDemo7
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            {
                al.Add("Baramati");
                al.Add(54.55);
                al.Add('t');
                al.Add(4);
                ArrayList al2 = new ArrayList();
                al.Add(78);
                al2.InsertRange(0, al);
                foreach (var x in al2)
                {
                    Console.WriteLine(x);
                }
            }
        }
    }
   
}






