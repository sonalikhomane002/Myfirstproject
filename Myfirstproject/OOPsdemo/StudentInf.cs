using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.OOPsdemo
{
    class StudentInf
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Marks { get; set; }


        static void Main(string[] args)
        {
            StudentGreatestMark studentGreatestMark = new StudentGreatestMark();
            studentGreatestMark.Id = 1;
            studentGreatestMark.Name = "Anil";
            studentGreatestMark.Marks = 89.76;


            StudentGreatestMark studentGreatestMark2 = new StudentGreatestMark();
            studentGreatestMark2.Id = 2;
            studentGreatestMark2.Name = "Sachin";
            studentGreatestMark2.Marks = 76.67;

            if (studentGreatestMark.Marks > studentGreatestMark2.Marks)
            {

                Console.WriteLine(studentGreatestMark.Id = 1);
                Console.WriteLine(studentGreatestMark.Name = "Anil");
                Console.WriteLine(studentGreatestMark.Marks = 89.76);
            }
            else
            {
                Console.WriteLine(studentGreatestMark2.Id = 1);
                Console.WriteLine(studentGreatestMark2.Name = "Anil");
                Console.WriteLine(studentGreatestMark2.Marks = 89.76);

            }
        }

    }
}
