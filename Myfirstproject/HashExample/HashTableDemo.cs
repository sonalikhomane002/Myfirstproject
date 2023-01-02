using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Myfirstproject.HashExample
{
    class HashTableDemo
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable()
            {
                {1,"sonali" },
                {2,"Pune" },
                {3,"Mumbai" }
            };
            foreach(DictionaryEntry kv in ht)
            {
                Console.WriteLine(kv.Key+" "+kv.Value);
            }
            ht.Remove(1);
            Console.WriteLine("...........................");
            foreach (DictionaryEntry kv in ht)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }
            Console.WriteLine("............................");
            Dictionary<int, string> dm = new Dictionary<int, string>();
            dm.Add(5, "red");
            dm.Add(6, "green");
            dm.Add(1, "pink");


        }
    }
}
