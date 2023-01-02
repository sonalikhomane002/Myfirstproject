using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;


namespace Myfirstproject.AssignmentOnCollection
{
    //WAP to add elements to and print content of it where Integer is used.
    //In the second arraylist String is used.

    class Class1
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();

            al.Add(34);
            al.Add(55);
            al.Add(22);
            al.Add(45);

            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }
        }
    }
    class class2
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("Red");
            al.Add("blue");
            al.Add("White");
            al.Add("Pink");

            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }

        }
    }
    //WAP to add elements to arraylist  0th location keep Integer,
    //1st location String now print each element and display contents.
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(12);
            al.Add("blue");
            al.Add(45);
            al.Add("Red");


            foreach (var x in al)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine(al[0]);
            Console.WriteLine(al[1]);
        }
    }
    //WAP to create a new ArrayList, add some colors (string) and print the collection.
    class Program1
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("Pink");
            al.Add("Blue");
            al.Add("White");
            al.Add("Red");

            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }


        }
    }
    //WAP of swap two elements in an ArrayList
    class Program3
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();

            al.Add(20);
            al.Add(10);


            for (int i = 0; i < al.Count; i++)
            {

                Console.WriteLine(al[i]);
            }
            Console.WriteLine("Swapping of Two element");
            int temp = 0;

            temp = (int)al[0];
            al[0] = al[1];
            al[1] = temp;

            Console.WriteLine("After swapping");
            for (int i = 0; i < al.Count; i++)
            {

                Console.WriteLine(al[i]);
            }
        }
    }
    //WAP to replace the second element of an ArrayList with the specified element
    class Program5
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();

            al.Add('t');
            al.Add(20);
            al.Add("Pune");
            al.Add(45.78);


            foreach (var x in al)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("......................");
            var element = "Goa";
            al[2] = element;
            foreach (var x in al)
            {
                Console.WriteLine(x);
            }

        }
    }
    //WAP to create a List of Students and iterate over it.
    class Student
    {
        public int id;
        public string name;
        public int rollno;
        public Student(int id, string name, int rollno)
        {
            this.id = id;
            this.name = name;
            this.rollno = rollno;

        }


    }
    class Demo
    {
        static void Main(string[] args)
        {

            List<Student> li = new List<Student>();

            li.Add(new Student(101, "Vikas", 12));
            li.Add(new Student(102, "Dhruv", 34));
            li.Add(new Student(103, "Komal", 13));
            li.Add(new Student(104, "Anjali", 22));

            foreach (Student e in li)
            {
                Console.WriteLine(e.id + " " + e.name + " " + e.rollno);
            }
            Console.WriteLine("................................");

        }
    }
    //WAP to print list in reverse order .
    class Program6
    {
        static void Main(string[] args)
        {
            var cityname = new List<string>()
            {
               "Baramati",
               "Pune",
               "Satara",
               "Goa"
            };
            foreach (String s in cityname)
            {
                Console.WriteLine(s);
            }
            cityname.Reverse();
            Console.WriteLine("after reverse the list");
            for (int i = 0; i < cityname.Count; i++)
            {
                Console.WriteLine(cityname[i]);
            }

        }
    }
    // WAP to get only the Keys from a Hashtable.
    class Program7
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable()
            {
                {1,"sonali" },
                {2,"pune" },
                {45,"mumbai" }
            };
            foreach(DictionaryEntry kv in ht)
            {
                Console.WriteLine();
            }
        }
    }
    //WAP to convert an array to ArrayList.
    class Collection
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            ArrayList al = new ArrayList();

            for (int i = 0; i < arr.Length; i++)
            {
                al.Add(arr[i]);
            }
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }
        }
    }
    //WAP to sort the elements of List that contain String objects.Print ArrayList
    class Collection9
    {
        static void Main(string[] args)
        {
            List<string> li = new List<string>()
            {
                "Red","Pink","Black","White","Orange"
            };
            li.ForEach(Lnum => Console.Write(Lnum + " "));
            for (int i = 0; i < li.Count; i++)
            {
                for (int j = i + 1; j < li.Count; j++)
                {
                    if (li[i].CompareTo(li[j]) > -1)
                    {
                        var temp = li[i];
                        li[i] = li[j];
                        li[j] = temp;
                    }
                }
            }
            Console.WriteLine();
            li.ForEach(Lnum => Console.Write(Lnum + " "));
        }
    }
    //WAP to create a class Employee with (name, designation and age).Now create and
    //add Employee objects elements to Arraylist. Sort the ArrayList by age in descending
    //order and print ArrayList.

    class Program34
    {
        public class Employee : IComparable
        {
            
            public string Name { get; set; }
            public string Designation { get; set; }
            public int Age { get; set; }
            public Employee(string name, string designation, int age)
            {
                this.Name = name;
                this.Designation = designation;
                this.Age = age;
            }

            public int CompareTo(object obj)
            {
                Employee e = (Employee)obj;
                return e.Age - this.Age;
            }
        }
        static void Main(string[] args)
        {
            ArrayList emp = new ArrayList();
            emp.Add(new Employee("Sonali", "Software Developer", 24));
            emp.Add(new Employee("Ankita", "Data Analyst", 26));
            emp.Add(new Employee("Priya", "Software Engineer", 23));
            emp.Add(new Employee("Mohini", "Database Engineer", 25));
            emp.Add(new Employee("Pratap", "Software Tester", 28));
            emp.Sort();
           
            foreach (Employee empl in emp)
            {
                Console.WriteLine(empl.Name + "  " + empl.Designation + "  " + empl.Age);
            }
        }
    }
    //WAP to create a Stack to store some objects and iterate over it.Also show use of push,pop,peek.
    class Program44
    {
        static void Main(string[] args)
        {
            Stack<string> s = new Stack<string>();
            s.Push("Red");
            s.Push("green");
            s.Push("blue");

            foreach(var st in s)
            {
                Console.WriteLine(st);
            }
            Console.WriteLine(s.Contains("green"));
            Console.WriteLine(s.Peek());
            Console.WriteLine("............................");
            foreach (var st in s)
            {
                Console.WriteLine(st);
            }
            s.Pop();
            Console.WriteLine("..........................");
            foreach (var st in s)
            {
                Console.WriteLine(st);
            }
        }
    }
    
}
