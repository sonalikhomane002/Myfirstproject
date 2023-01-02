using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.AssignmentOnInheritance
{
    /*Create class Teacher with following
    Tid,Tname,MobileNo
    Parameterized constructor
    abstract void salary()
    Create class Hourlybased which is derived class from teacher with fields
     rate_per_hr,
     int hrs;
     Parameterized constructor
     void salary()
     Create class SalaryBased which is derived class from teacher
     with fields
     int salary;
     Parameterized constructor
     void salary()
    Write main to create objects of HourlyBased teacher and SalaryBased teacher and also call respective salary method and also show runtime polymorphism*/

    abstract class Teacher
    {
        public int Tid;
        public string Tname;
        public long Mobileno;


        public Teacher(int Tid, string Tname, long Mobileno)
        {
            this.Tid = Tid;
            this.Tname = Tname;
            this.Mobileno = Mobileno;
        }
        public abstract void Display();

    }

    class Hourlybased : Teacher
    {
        public int rate_per_hr;
        public int hrs;


        public Hourlybased(int rate_per_hr, int hrs, int Tid, string Tname, long Mobileno) :
             base(Tid, Tname, Mobileno)
        {
            this.hrs = hrs;
            this.rate_per_hr = rate_per_hr;
        }

        public override void Display()
        {
            this.salary();
        }

        void salary()
        {
            Console.WriteLine("Hoursly based salary: " + this.rate_per_hr * this.hrs);
        }
    }
    class SalaryBased : Teacher
    {
        public int salary;


        public SalaryBased(int salary, int Tid, string Tname, int Mobileno) : base(Tid, Tname, Mobileno)
        {
            this.salary = salary;
        }
        public override void Display()
        {
            Console.WriteLine(salary);
        }
        static void Main(string[] args)
        {
            Teacher h = new Hourlybased(6, 5, 101, "sonali", 9970915673);
            Teacher s = new SalaryBased(20000, 11, "mona", 95527323);
            h.Display();
            s.Display();

        }
    }
    /*//A Pen contains variables Refill r, int capLength and  String brand. 
    Refill has variables inkColor, length and Nib(tip).
	 Nib has variables materialType and width.
    Create a Java class structure for above.
    Write a main method which sets values in all the variables
     using setter methods and prints all the variables using getter methods.*/

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
    /* Write a program to create 2 person objects.Take input or hardcode  for all two person
     * from console.Person class is as follows
      Person(int id, String name, Vehicle v)
      Vehicle(int vid, String vname)*/

    class Vehicle
    {
        public int vid;
        public string vname;

        public Vehicle(int vid, string vname)
        {
            this.vid = vid;
            this.vname = vname;

        }

    }
    class Person
    {
        public int id;
        public string name;
        public Vehicle v;

        public Person(int id, string name, Vehicle v)
        {
            this.id = id;
            this.name = name;
            this.v = v;
        }
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle(1, "FZS");
            Vehicle vehicle1 = new Vehicle(2, "TVS");
            Person person1 = new Person(1, "sonali", vehicle);
            Person person2 = new Person(2, "vikas", vehicle1);

        }

    }
    //Create interface Cake with a method declared as bake. Create 2 classes 
    // Strawberry, BlackForest both implementing Cake interface.
    interface Cake
    {
        void Bake();


    }
    class Strawberry : Cake
    {
        public void Bake()
        {
            Console.WriteLine("Strawberry Cake");
        }
    }
    class BlackForest : Cake
    {
        public void Bake()
        {
            Console.WriteLine("BlackForest cake");
        }
    }
    //Create interface IceCream with method eat and Juice with method drink, 
    //Create class Mastani which implements both interfaces.
    interface IIceCream
    {
        public void Eat();
   
    }
    interface IJuice
    {
        public void Drink();
        
    }
    class Mastani : IIceCream, IJuice
    {

        public void Eat()
        {
            Console.WriteLine("eat icecream");
        }
        public void Drink()
        {
            Console.WriteLine("Drink juice");
        }
    }
    class InterfaceDemo1
    {
        static void Main(string[] args)
        {
            IIceCream i = new Mastani();
            i.Eat();

            IJuice p = new Mastani();
            p.Drink();
        }
    }
   /* //6.	Design a class to overload a function volume() as follows:  [2M]
    (i) double volume(double r) – with radius ‘r’ as an argument, returns the volume of sphere using the formula:
    v = 4 / 3 × 22 / 7 × r3
     (ii)double volume(double h, double r) – with height ‘h’ and radius ‘r’ as the arguments, returns the volume of a cylinder using the formula:
    v = 22 / 7 × r2 × h
     (iii) double volume(double l, double b, double h) – with length ‘l’, breadth ‘b’ and height ‘h’ as the arguments, returns the volume of a cuboid using the formula:
    v = l × b × h
   */
    public class VolumeCal
    {
        double volume(double r)
        {
            double vol = (4 / 3.0) * (22 / 7.0) * r * r * r;
            return vol;
        }

        double volume(double h, double r)
        {
            double vol = (22 / 7.0) * r * r * h;
            return vol;
        }

        double volume(double l, double b, double h)
        {
            double vol = l * b * h;
            return vol;
        }

        public static void Main(String[] args)
        {
            VolumeCal obj = new VolumeCal();
            Console.WriteLine("Sphere Volume = " + obj.volume(6));

            Console.WriteLine("Cylinder Volume = " + obj.volume(5, 3.5));

            Console.WriteLine("Cuboid Volume = " + obj.volume(7.5, 3.5, 2));
          
        }
    }
    /*Design class Order (int ordered, String Orderdate, Customer cust, Item item)
      Customer(int custid, String custname, Address address)
      Address(String addr1, city, int pincode)
       Item(int itemid, String itemname, int price)
      Write constructors, properties in respective classes.*/

    class Item
    {
        int itemId;
        string itemName;
        int price;
        public Item(int id, string itemname, int Price)
        {
            this.itemId = id;
            this.itemName = itemname;
            this.price = Price;
        }
        public void ShowItem()
        {
            Console.WriteLine($"Item Details :=\nItem id : {itemId} \nItem Name : " +
                $"{itemName} \nPrice : {price}");
        }
    }
    class Address
    {
        string Adr1;
        string city;
        int pinCode;
        public Address(string addr1, string city, int PinCode)
        {
            this.Adr1 = addr1;
            this.city = city;
            this.pinCode = PinCode;
        }
        public void ShowAddress()
        {
            Console.WriteLine($"Address Details :=\nAddress : {Adr1}" +
                $"\nCity : {city}\nPinCode : {pinCode} ");
        }
    }
    class Customer
    {
        int custid;
        string custname;
        Address address;
        public Customer(int Cust_Id, string custName, Address addr)
        {
            this.custid = Cust_Id;
            this.custname = custName;
            this.address = addr;
        }
        public void ShowCustomer()
        {
            Console.WriteLine($"Customer Details :=\nCustomer id : {custid}\n" +
                $"Customer Name : {custname}");
            address.ShowAddress();
        }
    }
    class Order
    {
        int ordered;
        string Orderdate;
        Customer cust;
        Item item;
        public Order(int ordered, string OrdDate, Customer Customer, Item item)
        {
            this.ordered = ordered;
            this.Orderdate = OrdDate;
            this.cust = Customer;
            this.item = item;
        }
        public void ShowOrder()
        {
            Console.WriteLine($"Order Details :=\nOrdered : {ordered} \nOrder Date : " +
                $"{Orderdate}");
            cust.ShowCustomer();
            item.ShowItem();
        }
    }
    class Program9
    {
        static void Main(string[] args)
        {
            Order newOrder = new Order(201, "22/Dec/2022", new Customer(1234, "sonali",
           new Address("Raghukul Niwas", "pune", 411034)), new Item(511, "Bag", 600));

            newOrder.ShowOrder();
        }
    }






}