using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Constructor
{
    class ObjectReturning
    {
        int no;

        public ObjectReturning()
        {
            this.no = 0;
        }
        public ObjectReturning(int no)
        {
            this.no = no;
        }
        public void Display()
        {
            Console.WriteLine("Number is " + no);
        }
        public ObjectReturning add(ObjectReturning obj)
        {
            ObjectReturning temp = new ObjectReturning();
            temp.no = this.no + obj.no;
            return temp;
        }
        public ObjectReturning Compare(ObjectReturning obj)
        {
            ObjectReturning temp = new ObjectReturning();
            if (this.no > obj.no)
                temp = this;
            else
                temp = obj;
            return temp;
        }
        static void Main(String[] args)
        {
            ObjectReturning obj1 = new ObjectReturning(3);
            ObjectReturning obj2 = new ObjectReturning(5);
            ObjectReturning obj3 = obj1.add(obj2);
            obj1.Display();
            obj2.Display();
            obj3.Display();

            Console.WriteLine("After Comparison ");
            obj3 = obj1.Compare(obj2);
            obj1.Display();
            obj2.Display();
            obj3.Display();

            Console.ReadKey();
        }

    }
}
