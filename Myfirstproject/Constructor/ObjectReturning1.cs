using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Constructor
{
    class ObjectReturning1
    {
        int no;
        public ObjectReturning1()
        {
            this.no =0;
        }
        public ObjectReturning1(int no)
        {
            this.no = no;
        }
        public void Display()
        {
            Console.WriteLine("Number is="+no);
        }
        public ObjectReturning1 add(ObjectReturning1 obj)
        {
            ObjectReturning1 temp = new ObjectReturning1();
            temp.no = this.no + obj.no;
            return temp;


        }
        static void Main(string[] args)
        {
            ObjectReturning1 obj1 = new ObjectReturning1(3);
            ObjectReturning1 obj2 = new ObjectReturning1(5);
            ObjectReturning1 obj3 = obj1.add(obj2);

            obj1.Display();
            obj2.Display();
            obj3.Display();

        }

    }
}
