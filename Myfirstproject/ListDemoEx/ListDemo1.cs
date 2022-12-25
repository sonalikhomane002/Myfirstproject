using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ListDemoEx
{
    //Task even element from the list
    class ListDemo1
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>();

            li.Add(6);
            li.Add(4);
            li.Add(5);
            li.Add(2);
            li.Add(9);

            for (int i = 0; i < li.Count; i++)
            {
                if (li[i] % 2 == 0)
                {
                    Console.WriteLine(li[i]);
                }
            }
        }

    }
    //task Prime no from the list
    class ListDemo2
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>();

            li.Add(52);
            li.Add(3);
            li.Add(5);
            li.Add(36);
            li.Add(53);
            li.Add(7);
            li.Add(30);
            li.Add(2);

            for (int i = 0; i < li.Count; i++)
            {
                bool isprime = true;

                for (int j = 2; j <= li[i] / 2; j++)
                {
                    if (li[i] % j == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if (isprime == true)
                {

                    Console.WriteLine(li[i]);
                }
            }

        }
    }
    //Task List item in Ascending order
    class ListDemo3
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>();

            li.Add(6);
            li.Add(4);
            li.Add(5);
            li.Add(2);
            li.Add(9);

            for (int i = 0; i < li.Count; i++)
            {
                Console.WriteLine(li[i]);
            }
            for (int i = 0; i < li.Count; i++)
            {
                for (int j = i + 1; j < li.Count; j++)
                {
                    if (li[i] > li[j])
                    {
                        int temp = li[i];
                        li[i] = li[j];
                        li[j] = temp;
                    }
                }
            }
            Console.WriteLine("The list item in Ascending order");

            for (int i = 0; i < li.Count; i++)
            {
                Console.WriteLine(li[i]);
            }

        }
    }
    class Demo1
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>();

            li.Add(3);
            li.Add(5);
            li.Add(9);
            li.Add(7);

            for (int i = 0; i < li.Count; i++)
            {
                Console.WriteLine(li[i]);
            }
        }
    }
    class Demo2
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
            for (int i = 0; i < cityname.Count; i++)
            {
                Console.WriteLine(cityname[i]);
            }
            Console.WriteLine("...........................");
            foreach (String s in cityname)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("................................");
            cityname.ForEach(cname => Console.WriteLine(cname));
            Console.WriteLine(cityname.Contains("Pune"));
            Console.WriteLine(".........................");
            cityname.Remove("Goa");
            cityname.ForEach(cname => Console.WriteLine(cname));
            Console.WriteLine("..............................");
            cityname.RemoveAt(0);
            cityname.ForEach(cname => Console.WriteLine(cname));
            Console.WriteLine(".................................");
            cityname.Add("Bangaluru");
            cityname.Add("Hydrabad");
            cityname.ForEach(cname => Console.WriteLine(cname));
            Console.WriteLine("...........................");
            cityname.RemoveRange(2, 2);
            cityname.ForEach(cname => Console.WriteLine(cname));

        }
    }
    class ReverseDemo
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };

            Console.WriteLine(string.Join(" ", a));
            int j = a.Length - 1;
            for (int i = 0; i < a.Length / 2; i++)
            {
                int temp = a[i];
                a[i] = a[j];
                a[j] = temp;
                j--;
            }
            Console.WriteLine(string.Join(" ", a));
        }
    }
    class FreqencyCountArr
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 5, 2, 1, 1, 5, 2, 4, 6, 3 };

            for (int i = 0; i < arr.Length; i++)
            {
                int count = 1;
                bool isvisited = false;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (arr[i] == arr[k])
                    {
                        isvisited = true;
                        break;
                    }

                }
                if (isvisited == false)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine(arr[i] + "   " + count);
                }
            }
        }

    }
    class Task5
    {
        static void Main(string[] args)
        {
            SortedList<int, string> st = new SortedList<int, string>();
            st.Add(1, "pune");
            st.Add(2, "mumbai");
            st.Add(3, "baramati");
            st.Add(4, "satara");
            st.Add(5, "goa");
            st.Add(6, "nasik");

            foreach (var myvalue in st)
            {
                if (myvalue.Key % 2 == 0)
                {
                    Console.WriteLine(myvalue.Key + "  " + myvalue.Value);
                }
            }
        }
    }
    class Employee
    {
        public int id;
        public string name;
        public float salary;

        public Employee(int id, string name, float salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
    }

    class CustomList
    {
        static void Main(string[] args)
        {
            List<Employee> li = new List<Employee>();
            li.Add(new Employee(101, "sonali", 50000));
            li.Add(new Employee(102, "Dhruv", 26000));
            li.Add(new Employee(103, "priya", 20000));
            li.Add(new Employee(104, "anuj", 70000));
            li.Add(new Employee(105, "amol", 23000));

            foreach (Employee emp in li)
            {
                if (emp.salary >= 25000)
                {
                    Console.WriteLine(emp.id + "  " + emp.name + "   " + emp.salary);
                }
            }
        }

    }
    //Task car
    class Car : IComparable
    {
        public int modelno;
        public string carname;
        public int carprice;
        public string carcolor;

        public Car(int modelno, string carname, int carprice, string carcolor)
        {
            this.modelno = modelno;
            this.carname = carname;
            this.carprice = carprice;
            this.carcolor = carcolor;

        }
        public int CompareTo(object obj)
        {
            Car c = (Car)obj;


            // return c.carname.CompareTo(this.carname);//desending order name
            // return this.modelno - c.modelno;
            return this.carprice - c.carprice;
            // return c.carprice - this.carprice;

            //return c.carprice - this.carprice;//descending sort on carprice




            /* if (this.carprice == c.carprice)
              {
                  return this.carprice - c.carprice;
              }
             else
             {
                 return c.carprice - this.carprice;
             }*/




        }
    }

    // int IComparable<Car>.CompareTo(Car other)
    // {
    /* *//* if(this.carprice>other.carprice)
      {
          return 1;
      }
      else if (this.carprice > other.carprice)
      {
          return -1;

      }
      else
      {
          return 0;
      }*//*

     return other.carprice - this.carprice;

  */
    // return other.carprice - this.carprice;//descending sort on carprice

    // }

    //
    class CustomListDemo2
    {
        static void Main(string[] args)
        {
            List<Car> li = new List<Car>();
            li.Add(new Car(2366, "Breeza", 1200000, "White"));
            li.Add(new Car(8041, "Breza", 1200000, "Black"));
            li.Add(new Car(1111, "i20", 900000, "White"));
            li.Add(new Car(2341, "Swift", 400000, "White"));

            foreach (Car c in li)
            {
                Console.WriteLine(c.modelno + " " + c.carname + " " + c.carprice + " " + c.carcolor);
            }
            Console.WriteLine("................................");

            li.Sort();

            foreach (Car c in li)
            {
                Console.WriteLine(c.modelno + " " + c.carname + " " + c.carprice + " " + c.carcolor);
            }
            Console.WriteLine("................................");

        }
    }
    //Task Employee
    class Employee1 : IComparable
    {
        public int id;
        public string name;
        public int salary;
        public Employee1(int id, string name, int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;

        }

        public int CompareTo(object obj)
        {
            Employee1 e = (Employee1)obj;


            return this.salary - e.salary;
        }
    }
    class CustomListDemo3
    {
        static void Main(string[] args)
        {

            List<Employee1> li = new List<Employee1>();
            li.Add(new Employee1(101, "Vikas", 52000));
            li.Add(new Employee1(102, "Dhruv", 20000));
            li.Add(new Employee1(103, "Komal", 49000));
            li.Add(new Employee1(104, "Anjali", 41000));

            foreach (Employee1 e in li)
            {
                Console.WriteLine(e.id + " " + e.name + " " + e.salary);
            }
            Console.WriteLine("................................");

            li.Sort();

            foreach (Employee1 e in li)
            {
                Console.WriteLine(e.id + " " + e.name + " " + e.salary);
            }
            Console.WriteLine("................................");
        }
    }
    class Car2
    {
        public int model;
        public string name;
        public int price;

        public Car2(int model, string name, int price)
        {
            this.model = model;
            this.name = name;
            this.price = price;


        }
    }
    class CDemo
    {
        static void Main(string[] args)
        {
            List<Car2> li = new List<Car2>();
            li.Add(new Car2(2366, "Breeza", 100000));
            li.Add(new Car2(8041, "Breza", 1200000));
            li.Add(new Car2(1111, "i20", 900000));
            li.Add(new Car2(2341, "Swift", 400000));

            foreach (var c in li)
            {
                Console.WriteLine(c.model + " " + c.name + " " + c.price);
            }
            Console.WriteLine("................................");


            // li.Sort(new SortbyModel());
            // li.Sort(new SortbyName());
            li.Sort(new SortbyPrice());



            foreach (var c in li)
            {
                Console.WriteLine(c.model + " " + c.name + " " + c.price);
            }
            Console.WriteLine("................................");




        }
    }
    class SortbyModel : IComparer<Car2>
    {
        int IComparer<Car2>.Compare(Car2 x, Car2 y)
        {
            return x.model - y.model;
        }
    }
    class SortbyName : IComparer<Car2>
    {
        int IComparer<Car2>.Compare(Car2 x, Car2 y)
        {
            return y.name.CompareTo(x.name);
        }
    }
    class SortbyPrice : IComparer<Car2>
    {
        int IComparer<Car2>.Compare(Car2 x, Car2 y)
        {
            return x.price - y.price;

        }
    }
    class Train
    {
        public int train_id;
        public string train_name;
        public int no_of_seats;

        public Train(int train_id, string train_name, int no_of_seats)
        {
            this.train_id = train_id;
            this.train_name = train_name;
            this.no_of_seats = no_of_seats;
        }
    }
    class No_Of_Seats : IComparer<Train>
    {
        int IComparer<Train>.Compare(Train x, Train y)
        {
            if (x.no_of_seats == y.no_of_seats)
            {
                return y.train_name.CompareTo(x.train_name);
            }
            return x.no_of_seats - y.no_of_seats;
        }
    }
    class SortName : IComparer<Train>
    {
        int IComparer<Train>.Compare(Train x, Train y)
        {
            return y.train_name.CompareTo(x.train_name);
        }
    }
    class ComparerList2
    {
        static void Main(string[] args)
        {
            List<Train> li = new List<Train>();
            li.Add(new Train(101, "Jammutavi", 1750));
            li.Add(new Train(102, "AzadHindExp", 1750));
            li.Add(new Train(103, "MumbaiExp ", 1550));
            li.Add(new Train(104, "HawdaExp ", 1420));

            foreach (Train t in li)
            {
                Console.WriteLine(t.train_id + " " + t.train_name + " " + t.no_of_seats);
            }
            Console.WriteLine(" ..........................................");
            //li.Sort(new No_Of_Seats());
            li.Sort(new SortName());


            foreach (Train t in li)
            {
                Console.WriteLine(t.train_id + " " + t.train_name + " " + t.no_of_seats);
            }

        }
    }
    //demo
    class Employee2
    {
        public int eid;
        public string name;

        public Employee2(int eid, string name)
        {
            this.eid = eid;
            this.name = name;
        }

    }
    class Department
    {
        public int did;
        public string dname;
        public List<Employee2> el;

        public Department(int did, string dname, List<Employee2> el)
        {
            this.did = did;
            this.dname = dname;
            this.el = el;
        }

    }
    class CustomListDemo
    {
        static void Main(string[] args)
        {
            List<Department> li = new List<Department>();

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Enter the did");
                int dtid = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the dname");
                string dnm = Console.ReadLine();
                List<Employee2> em = new List<Employee2>();

                Console.WriteLine("Enter the Employee Details");
                for (int j = 1; j <= 2; j++)
                {
                    Console.WriteLine("Enter the employee id");
                    int eid = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the employee name");
                    string name = Console.ReadLine();
                    em.Add(new Employee2(eid, name));

                }
                li.Add(new Department(dtid, dnm, em));
            }
            Console.WriteLine("............................");
            foreach (var d in li)
            {
                Console.WriteLine(d.did + " " + d.dname + " ");
                foreach (var e in d.el)
                {
                    Console.WriteLine(" " + e.eid + " " + e.name);
                }
                Console.WriteLine();
            }

        }
    }

    //Task student Marks
    class Marks
    {
        public string SubName;
        public int SubMarks;

        public Marks(string SubName, int SubMarks)
        {
            this.SubName = SubName;
            this.SubMarks = SubMarks;
        }
    }
    class Student
    {
        public int s_id;
        public string s_name;
        public List<Marks> lm;

        public Student(int s_id, string s_name, List<Marks> lm)
        {
            this.s_id = s_id;
            this.s_name = s_name;
            this.lm = lm;
        }
    }
    class StudentList
    {
        static void Main(string[] args)
        {
            List<Student> li = new List<Student>();
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine("Enter the Student Id :");
                int ID = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Student Name :");
                string Name = Console.ReadLine();
                List<Marks> ml = new List<Marks>();
                Console.WriteLine("Enter the details of Subject_name & Marks");
                for (int j = 1; j <= 2; j++)
                {
                    Console.WriteLine("Enter the subject_name :");
                    string S_Name = Console.ReadLine();
                    Console.WriteLine("Enter the  Subject marks :");
                    int S_Marks = int.Parse(Console.ReadLine());
                    ml.Add(new Marks(S_Name, S_Marks));
                }
                li.Add(new Student(ID, Name, ml));
            }
            Console.WriteLine("..............");
            foreach (var s in li)
            {
                Console.Write(s.s_id + "  " + s.s_name + "  ");
                foreach (var m in s.lm)
                {
                    Console.Write("  " + m.SubName + "  " + m.SubMarks);
                }
                Console.WriteLine();
            }
        }
    }
    class ListDemoTask
    {
        static void Main(string[] args)
        {
            List<string> li = new List<string>();

            li.Add("Pune");
            li.Add("Mumbai");
            li.Add("satara");
            li.Add("nasik");
            li.Add("Pune");

            for (int i = 0; i < li.Count; i++)
            {
                int count = 1;
                for (int j = i + 1; j < li.Count; j++)
                {
                    if (li[i] == li[j])
                    {
                        count++;
                        li.RemoveAt(j);
                        j--;

                    }
                }
                Console.WriteLine(li[i] + "  " + count);

            }
            Console.WriteLine(".................................");


        }

    }
    //task string list sort on the basis of length
    class Task
    {
        static void Main(string[] args)
        {
            List<string> li = new List<string>()
            {
                "Hyderabad",
                "Pune",
                "Nagpur",
                "Chennai",
                "Goa",
                "Aurangabad"
            };
            Console.WriteLine("Display the list according to the length in ascending order");
            for (int i = 0; i < li.Count; i++)
            {
                for (int j = i + 1; j < li.Count; j++)
                {
                    if (li[i].Length > li[j].Length)
                    {
                        string temp = li[i];
                        li[i] = li[j];
                        li[j] = temp;
                    }
                    else if (li[i].Length == li[j].Length)
                    {
                        if (li[i].CompareTo(li[j]) < 1)
                        {
                            string temp = li[i];
                            li[i] = li[j];
                            li[j] = temp;
                        }
                    }
                }
            }
            foreach (string city in li)
            {
                Console.WriteLine(city + "   ");
            }
        }
    }
    class Task22
    {
        static void Main(string[] args)
        {
            int[] ar = { 2, 3, 4, 5, 6, 7 };
            int sum = 0;

            for (int i = 0; i < ar.Length; i++)
            {
                bool isprime = true;
                for (int j = 2; j < ar[i]; j++)
                {
                    if (ar[i] % j == 0)
                    {
                        isprime = false;
                        break;
                    }

                }
                if (isprime == true)
                {

                    sum = sum + ar[i];
                    //Console.WriteLine(sum);
                }

            }
            Console.WriteLine(sum);



        }
    }
    /*//WAP to create a List<Emp> and search for Emp object whose	
    Empno=10 and delete all the records whose dept is same as
    empno 10. 
    Emp[Empno, ename, Dept d]
    Dept[did, dname]*/

    class Department2
    {
        public int did;
        public string name;

        public Department2(int did, string name)
        {
            this.did = did;
            this.name = name;


        }
    }
    class Employee22
    {
        public int empno;
        public string ename;
        public int  deptId;

        

       

        public Employee22(int empno, string ename, int deptId)
        {
            this.empno = empno;
            this.ename = ename;
            this.deptId = deptId;

        }
        static void Main(string[] args)
        {
            List<Employee22> li = new List<Employee22>();
            List<Department2> listOfDept = new List<Department2>();
            listOfDept.Add(new Department2(1,"IT"));
            listOfDept.Add(new Department2(2,"HR"));
            listOfDept.Add(new Department2(3,"CC"));
            listOfDept.Add(new Department2(4,"AA"));

            for (int i = 1; i < 3; i++)
            {
                Console.WriteLine("Enter the empno");
                int empno = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the ename");
                string ename = Console.ReadLine();
                Console.WriteLine("enter the Dept Id");
                int deptId = int.Parse(Console.ReadLine());
                Employee22 e = new Employee22(empno, ename,deptId);
            }
            int deptid=0;
            for(int i=0;i<li.Count;i++)
            {
              if(li[i].empno==10)
              {
                    deptid = li[i].deptId;
                
              }
            }

            for(int i=0;i<li.Count;i++)
            {
                if(deptid==li[i].deptId)
                {
                    li.RemoveAt(i);
                }

            }
                
        }
    }
}
    









