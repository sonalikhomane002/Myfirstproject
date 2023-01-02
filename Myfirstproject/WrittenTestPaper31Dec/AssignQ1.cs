using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.WrittenTestPaper31Dec
{
    /*
    //1.	Assume you have Arraylist  al = new ArrayList ();
         al.Add("Sun");
         al.Add("Mon");
         al.Add("Sat");
         al.Add("Sun ");
         al.Add("Mon ");
         al.Add("Sat ");
         al.Add("Sun ");
         al.Add("Sat ");
         al.Add("Sun ");
         al.Add("Mon ");
         Write a code to remove duplicate elements from above list.
         Final Arraylist should contain (Sun, Mon, Sat);*/


    class AssignQ1
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("Sun");
            al.Add("Mon");
            al.Add("Sat");
            al.Add("Sun ");
            al.Add("Mon ");
            al.Add("Sat ");
            al.Add("Sun ");
            al.Add("Sat ");
            al.Add("Sun ");
            al.Add("Mon ");

            Dictionary<string, string> dl = new Dictionary<string, string>();
            for (int i = 0; i < al.Count; i++)
            {
                if (!dl.ContainsKey(al[i].ToString().Trim()))
                {
                    dl.Add(al[i].ToString().Trim(), al[i].ToString());
                }
            }

            foreach (KeyValuePair<string, string> days in dl)
            {
                Console.WriteLine(days.Key.ToString());
            }

        }

    }
    //Sort Arraylist of String in reverse order of its natural sorting. 
    class AssignQ2
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList()
            {
                "Ashish",
                "Dhruv",
                "pranali",
                "Vikas",
                "Neeta"

            };
            for (int i = 0; i < al.Count; i++)
            {
               for(int j=i+1;j<al.Count;j++)
                {
                    if (al[i].ToString().CompareTo(al[j].ToString()) < 1) ;
                    {
                        var temp = al[i];
                        al[i] = al[j];
                        al[j] = temp;
                    }
                }
            }
            foreach (var item in al)
            {

                Console.Write(item + "  ");

            }
        }
    }
    /* //8.	ArrayList Contains 
        al.Add("pune");
       al.Add("Mumbai");
       al.Add("pune");
       al.Add("Mumbai");
       al.Add("Nasik");
      al.Add("pune");
      Create a HashTable which contain String as key and Integer as 
      value key is name of city and value is frequency of that city.
     ("pune",3);
     ("Mumbai",2);
      Print hashtable using Foreach loop.*/
    class AssingnQ8
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();

            al.Add("pune");
            al.Add("Mumbai");
            al.Add("pune");
            al.Add("Mumbai");
            al.Add("Nasik");
            al.Add("pune");

            Hashtable ht = new Hashtable();

            for (int i = 0; i < al.Count; i++)
            {
                if (ht.ContainsKey(al[i]))
                {
                    ht[al[i]] = Convert.ToInt32(ht[al[i]]) + 1;
                }
                else
                {
                    ht.Add(al[i], 1);
                }

            }
            foreach (DictionaryEntry kv in ht)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }
        }
    }
    /* 3.The encryption of alphabets are to be done as follows:	[2]
       A=1,B=2,C=3,Z=26
       The potential of a word is found by adding the encrypted value of the alphabets.
       Example: KITE
       Potential = 11 + 9 + 20 + 5 = 45
       Accept a sentence Decode the words according to their potential and arrange them in ascending order.
        Output the result in format given below:
       Input:THE SKY IS THE LIMIT.
       POTENTIAL:THE= 33, SKY= 55, IS= 28, THE= 33, LIMIT= 63
       Output :IS THE THE SKY LIMIT*/


    class KeyValue
    {
        public string key;
        public int value;
    }
    class AssignQ3
    {
        static void Main(string[] args)
        {

            Dictionary<char, int> dl = new Dictionary<char, int>();
            for (int i = 0, j = 65; i < 26; i++, j++)
            {
                dl.Add(Convert.ToChar(j), i);
            }
            Console.WriteLine("enter the string");
            string str = Console.ReadLine();
            str = str.ToUpper();
            string[] words = str.Split(' ');
            List<KeyValue> keyValues = new List<KeyValue>();
            
            for (int j = 0; j < words.Length; j++)
            {
                int sum = 0;
                for (int i = 0; i < words[j].Length; i++)
                {
                    sum = sum + dl[words[j][i]];
                }

                keyValues.Add(new KeyValue { key = words[j], value = sum });
            }

            keyValues.Sort((x, y) => x.value.CompareTo(y.value));


            keyValues.ForEach(x => Console.WriteLine(x.key + " " + x.value));
        }

    }
    //7.Create a HashTable  where key is integers 1 to 10 and string is number in Words.
    //Remove entry for which number is divisible by 3.
    class AssignQ7
    {
        static void Main(string[] args)
        {

            Hashtable ht = new Hashtable()
            {
                {1,"One"},
                {2,"Two"},
                {3,"Three"},
                {4,"Four"},
                {5,"Five"},
                {6,"Six"},
                {7,"Seven"},
                {8,"Eight"},
                {9,"Nine"},
                {10,"Ten"}
            };

            Hashtable ht1 = new Hashtable();

            foreach (DictionaryEntry kv in ht)
            {
                if (Convert.ToInt16(kv.Key) % 3 != 0)
                {
                    ht1.Add(kv.Key, kv.Value);
                }

            }


            foreach (DictionaryEntry kv in ht1)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }


        }
    }
    class AssignQ5
    {

      
        public static void Main()
        {

            
            Hashtable myTable = new Hashtable();

         
            myTable.Add("g", "PHP");
            myTable.Add("c", "c++");
            myTable.Add("d", "data structures");
            myTable.Add("q", "Java");

         
            ICollection c = myTable.Keys;

         
            foreach (string str in c)
                Console.WriteLine(str + ": " + myTable[str]);

           
            myTable["c"] = "C#";

            Console.WriteLine("Updated Values:");

        
            foreach (string str in c)
                Console.WriteLine(str + ": " + myTable[str]);
        }
    }
    class AssignQ6
    {

        
        public static void Main()
        {

            
            Hashtable myTable = new Hashtable();

         
            myTable.Add("4", "Even");
            myTable.Add("9", "Odd");
            myTable.Add("5", "Odd and Prime");
            myTable.Add("2", "Even and Prime");

          
            ICollection c = myTable.Keys;

            
            foreach (string str in c)
                Console.WriteLine(str + ": " + myTable[str]);

           
            myTable["56"] = "New Value";

            Console.WriteLine("Updated Values:");

           
            foreach (string str in c)
                Console.WriteLine(str + ": " + myTable[str]);
        }
    }
    class AssignQ4
    {
        class Player
        {
            public int pid;
            public string pname;
            public string country;
            public string team;

            public Player(int pid, string pname, string country, string team)
            {
                this.pid = pid;
                this.pname = pname;
                this.country = country;
                this.team = team;


            }
        }

            static void Main(string[] args)
            {
                List<Player> pl = new List<Player>();
                pl.Add(new Player(101, "MsDhoni", "India", "CSK"));
                pl.Add(new Player(131, "Bravo", "West India", "CSK"));
                pl.Add(new Player(144, "DevodWarner", "Aistralia", "SRH"));
                pl.Add(new Player(161, "josh", "Australia", "csk"));
                pl.Add(new Player(109, "tim", "Australia", "Csk"));

                Dictionary<string, int> dt = new Dictionary<string, int>();
                int cnt = 0;
                for (int i = 0; i < pl.Count; i++)
                {
                    for (int j = 0; j < pl.Count; j++)
                    {
                        if (pl[i].team == pl[j].team && pl[i].country == "Australia" && pl[j].country == "Australia")
                        {
                            cnt++;
                            j--;
                        }
                        if (!dt.ContainsKey(pl[i].team))
                        {
                            dt.Add(pl[i].team, cnt);

                        }
                    }
                    foreach (KeyValuePair<string, int> kv in dt)
                    {
                        Console.WriteLine(kv.Key + " " + kv.Value);
                    }

                }


            }
        
    } 

}




