using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.WrittenTest24Dec
{
    //write a program to sort List by decending without using sort method and without
    //converting into array.							
    class Class1
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>()
            { 
                9,7,6,4,5,3,10
            };


            for (int i=0;i<li.Count;i++)
            {
                for(int j=i+1;j<li.Count;j++)
                {
                    if(li[i]<li[j])
                    {
                        int temp = li[i];
                        li[i] = li[j];
                        li[j] = temp;
                    }
                }
            }
            
            foreach(var item in li)
            {
                Console.WriteLine(item+" ");
            }

        }
    }
    //Write a  program to Remove duplicate elements from List. 
    class Program2
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>()
            { 
                10,15,16,18,20,10,15,18,17
            };
            for(int i=0;i<li.Count;i++)
            {
                for(int j=i+1;j<li.Count;j++)
                {
                  if(li[i].Equals(li[j]))
                    {
                        li.RemoveAt(j);
                    }
                }
            }
            foreach(var item in li)
            {
                Console.WriteLine(item+" ");
            }
        }
    }

    //predict the output
    public class Output
    {
        static void Main(String[] args)
        {
            List<String> list1 = new List<string>();
            list1.Add("Me");
            list1.Add("You");
            list1.Add("He");
            list1.Add("She");
            list1.Add("It");
            List<String> list2 = new List<string>();
            list2.Add("You");
            list1.AddRange(list2);
            foreach (String temp in list2)
            {
                Console.WriteLine(temp + "  ");
            }
        }

    }
    /*//WAP to create a List<Emp> and search for Emp object whose	
    Empno=10 and delete all the records whose dept is same as
    empno 10*/
    class Dept
    {
        public int did;
        public string dname;

        public Dept(int did,string dname)
        {
            this.did = did;
            this.dname = dname;
        }

    }
    class Emp
    {
        public int empNo;
        public string ename;
        public Dept dept;

        public Emp(int empno,string ename,Dept dept)
        {
            this.empNo = empno;
            this.ename = ename;
            this.dept = dept;


        }
    }
    class Program
    { 
        static void Main(String[]args)
        {
            List<Emp> li = new List<Emp>();
            li.Add(new Emp(20, "sonali", new Dept(101, "Head")));
            li.Add(new Emp(10, "priya", new Dept(102, "HR")));
            li.Add(new Emp(30, "vikas", new Dept(103, "sales")));
            li.Add(new Emp(40, "Amol", new Dept(104, "HR")));
            li.Add(new Emp(50, "Mahi", new Dept(105, "sales")));

            for(int i=0;i<li.Count;i++)
            {
                if(li[i].empNo==10)
                {
                  for(int j=i+1;j<li.Count;j++)
                    {
                        if(li[i].dept.dname.Equals(li[j].dept.dname))
                        {
                            li.RemoveAt(j);
                        }
                    }
                }
            }
            foreach(Emp e in li)
            {
                Console.WriteLine(e.empNo+" "+e.ename+" "+e.dept.dname);
            }
        }
    }
   /* Consider an List of Movie
     Movie has(int movieid, String moviename, List<String> actor)
     Find “Amitabh bachchan has acted in how many movies*/
   class Movie
   {
        public int mid;
        public string mName;
        public List<string> mactor;

        public Movie(int mid,string mName,List<string>mactor)
        {
            this.mid = mid;
            this.mName = mName;
            this.mactor = mactor;

        }

    }
    class Program22
    {
        static void Main(string[] args)
        {
            List<Movie> ml = new List<Movie>();

            ml.Add(new Movie(121, "Deewar", new List<string>() { "sashi kapoor", "Amitabh", "Yash" }));
            ml.Add(new Movie(159, "Sholey", new List<string>() { "Dharmendra", "Amitabh", "Hema" }));
            ml.Add(new Movie(112, "Ek Tha Tiger", new List<string>() { "salman", "Katrina", "paresh" }));
            ml.Add(new Movie(100, "Bajrangi Bhaijaan", new List<string>() { "salman",  "Nawazuddin" }));

            int Amitabhmcnt = 0;
            foreach(Movie m in ml)
            {
                if(m.mactor.Contains("Amitabh"))
                {
                    Console.WriteLine(m.mName);
                    Amitabhmcnt++;
                }
            }
            Console.WriteLine("total Movies="+ Amitabhmcnt);
        }
    }
    /*Write a program to find all pairs of elements in an integer array whose sum is equal to a given number?
      Input Array : [4, 6, 5, -10, 8, 5, 20]
      InputNumber:10
      Pairs of elements whose sum is 10 are :
      4 + 6 = 10
      5 + 5 = 10
      -10 + 20 = 10*/
    class Program11
    {
        static void Main(string[] args)
        {
            int[] ar = { 4, 6, 5, -10, 8, 5, 20,6};
            List<string> l = new List<string>();
            int num = 10;
            for(int i=0;i<ar.Length;i++)
            {
                for(int j=i+1;j<ar.Length;j++)
                {
                    if (ar[i] + ar[j] == num)
                    {
                       for(int k=0;k<l.Count;k++)
                        {
                            //()
                        }
                    }
            
                }
                
             
            }

        }
    }

     /*//) A Pen contains variables Refill, capLength and brand. Refill has variables
    inkColor, length and Nib(tip). Nib has variables materialType and width.Create
    class structure for above.Write a main method which sets values in all the variables
     using setter methods and prints all the variables using getter methods. (consider getter, setter are present in all classes only write main method)				
    */
    class Nib
    {
        //set and get
        private string materialtype;
        private float width;

        public string Materialtype
        {
            get { return materialtype; }
            set { materialtype = value; }
        }
        public float Width
        {
            get { return width; }
            set { width = value; }
        }
    }
    class Refil
    {
        private string inkcolor;
        private float length;
        private Nib _nib;


        public string Inkcolor
        {
            get { return inkcolor; }
            set { inkcolor = value; }

        }
        public float Length
        {
            get { return length; }
            set { length = value; }
        }
        public Nib nib
        {
            get { return _nib; }
            set { _nib = value; }
        }

    }
    class Pen
    {
        private float capLength;
        private string brand;
        private Refil _refil;

        public float CapLength
        {
            get { return capLength; }
            set { capLength = value; }
        }
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public Refil refil
        {
            get { return _refil; }
            set { _refil = value; }

        }

    }
    class Client
    {
        static void Main(string[] args)
        {
            Pen p1 = new Pen();
            p1.CapLength = 2.1f;
            p1.Brand = "Cello";
            Refil r1 = new Refil();
            r1.Inkcolor = "Blue";
            r1.Length = 2.5f;
            Nib n1 = new Nib();
            n1.Materialtype = "steel";
            n1.Width = 2.4f;
            r1.nib = n1;
            p1.refil = r1;

            Console.WriteLine("CapLength=" + p1.CapLength + "\nBrand="
                + p1.Brand + "\nInkcolor=" + p1.refil.Inkcolor + "\nLength="
                + p1.refil.Length + "\nMaterial type=" + p1.refil.nib.Materialtype + "\nWidth="
                + p1.refil.nib.Width);
        }
    }

}



