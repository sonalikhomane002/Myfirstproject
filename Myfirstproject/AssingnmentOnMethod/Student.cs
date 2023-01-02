using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.AssingnmentOnMethod
{

   /* // add method displayData inside Student class change
      values of id name in that method & also print the changed
     values in same method.Call displayData method from
     main method and see the output.Observe displayData can
      only be called by creating object of Student*/

    class Student
    {
        int sid = 1;
        string name = "vikas";
        public void DisplayData()
        {

            Console.WriteLine("id="+this.sid);
            Console.WriteLine("name="+this.name);

        }
        static void Main(string[] args)
        {
            Student student = new Student();
            student.sid = 2;
            student.name = "kajal";
            student.DisplayData();

        }
    }
   /* // Create getId() method in Student class. call getId() method
    from displayData method so that you know that one
    method can be called from another method.Return id
    from getId() method and set that id to the instance
    variable in displayData method
    */
   class Student2
    {


    }
}
