using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.TuplesDemo
{
    class Person
    {
        public int id;
        public string name;
        public string city;

        public Person(int id,string name,string city)
        {
            this.id = id;
            this.name = name;
            this.city = city;
        }
        public static Tuple<int, string, string> GetPerson()
        {
            return Tuple.Create(100, "sonali", "hydrabad");
        }
    }
    
    class TupleDemo
    {
        static void Main(string[] args)
        {
             //var person = Tuple.Create(1, "Sonali", "pune");
            // Console.WriteLine(person.Item2);
            var employee = Person.GetPerson();
            Console.WriteLine(employee.Item3);
        }
    }
    class TupleDemo4
    {
        static void Main(string[] args)
        {
            var mytuple = Tuple.Create(2, "one", 9, "four");
            Console.WriteLine(mytuple.Item1);
            Console.WriteLine(mytuple.Item3);

            var nesttuple = Tuple.Create(1, 2, Tuple.Create(122, 456));
            Console.WriteLine(nesttuple.Item1);



        }
    }


}
