using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.QueueDemo
{
    class QueueDemo
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(5);
            q.Enqueue(50);
            q.Enqueue(56);
            q.Enqueue(74);
            q.Enqueue(52);
            q.Enqueue(12);
            Console.WriteLine("Element in queue = " + q.Count);
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(".........DEQ..." + q.Dequeue());
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("......Peek....." + q.Peek());
            Console.WriteLine(q.Contains(56));
            q.Clear();
            Console.WriteLine("Element in queue..." + q.Count);
            Console.WriteLine(q.Peek());

        }
    }
    class QueueDemo1
    {
        class Student
        {
            public int sid;
            public string sname;
            public double smarks;
            public Student(int sid, string sname, double smarks)
            {
                this.sid = sid;
                this.sname = sname;
                this.smarks = smarks;
            }
            public void DisplayStudent()
            {
                Console.WriteLine(sid + "\t" + sname + "\t" + smarks);
            }
        }
        static void Main(string[] args)
        {
            Queue<Student> sq = new Queue<Student>();
            sq.Enqueue(new Student(14, "anita", 85.20));
            sq.Enqueue(new Student(12, "rohini", 50.60));
            sq.Enqueue(new Student(11, "akash", 65.30));
            sq.Enqueue(new Student(17, "mohini", 70.0));
            sq.Enqueue(new Student(16, "nikhil", 80.80));
            sq.Enqueue(new Student(15, "sapna", 55.20));

            foreach (Student s in sq)
            {
                if (s.smarks > 60.0)
                {
                    s.DisplayStudent();
                }
            }


        }
    }
    class QueDemo
    {
        static void Main(string[] args)
        {
            Queue<string> myqueue = new Queue<string>();
            myqueue.Enqueue("c #");
            myqueue.Enqueue("Management");
            myqueue.Enqueue("java");
            myqueue.Enqueue("Android");
            myqueue.Enqueue("Mobile Application");

            foreach(var item in myqueue)
            {
                Console.WriteLine(item);
            }



        }
    }
    class Example
    {
        static void Main(string[] args)
        {
            Queue<string> q = new Queue<string>();
            q.Enqueue("India");
            q.Enqueue("US");
            q.Enqueue("Australia");
            q.Enqueue("Japan");
            q.Enqueue("Maxico");

            foreach(string s in q)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("................................");
            Console.WriteLine("Peek element="+q.Peek());
            Console.WriteLine("......................");
            Console.WriteLine("Dequeue"+q.Dequeue());
            Console.WriteLine("..................................");
            Console.WriteLine("peek element ="+ q.Peek());
        }
    }

}
