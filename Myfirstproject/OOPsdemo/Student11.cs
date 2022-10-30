using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPsdemo
{
    class Student11
    {
       int id;
       string name;
       int marks;
       bool result;

        public int Id
        {
            set
            {
                id = value;
            }
            get
            {
                return id;
            }
        }
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public int Marks
        {
            set
            {
                marks = value;
            }
            get
            {
                return marks;
            }
        }
        public bool Result
        {
            set
            {
                result = value;
            }
            get
            {
                return result;
            }
        }
        public string ActualResult
        {
            get
            {
                return result ? "pass" : "fail";
            }
        }

        //static void Main(string[] args)
        //{
        //    Student11 studentInfo = new Student11();

        //    studentInfo.Id = 101;
        //    studentInfo.Name = "Dhruv";
        //    studentInfo.Marks = 67;
        //    studentInfo.Result = false;

        //    Console.WriteLine(studentInfo.Id);
        //    Console.WriteLine(studentInfo.Name);
        //    Console.WriteLine(studentInfo.Marks);
        //    Console.WriteLine(studentInfo.Result ? "Pass" : "Fail");
        //    Console.WriteLine(studentInfo.ActualResult);

        //}



    }
    class StudentInfoTest
    {
        static void Main(string[] args)
        {
            Student11 studentInfo = new Student11();

            studentInfo.Id = 101;
            studentInfo.Name = "Dhruv";
            studentInfo.Marks = 67;
            studentInfo.Result = false;

            Console.WriteLine(studentInfo.Id);
            Console.WriteLine(studentInfo.Name);
            Console.WriteLine(studentInfo.Marks);
            Console.WriteLine(studentInfo.Result ? "Pass" : "Fail");
        }
    }
}
