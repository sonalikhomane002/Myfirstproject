using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Constructor
{
    class ObjectAsParameter
    {
        int no, sum;

        public ObjectAsParameter(int no)
        {
            this.no = no;
        }
        public void Add(ObjectAsParameter obj)
        {
             sum = this.no + obj.no;
        }
        public bool compare(ObjectAsParameter obj)
        {
            if (no > obj.no)
                return true;
            else
                return false;
        }
        
        public void putinfo()
        {
            Console.WriteLine("Addition of 2 object is"+sum);
        }
        static void Main(string[] args)
        {
            ObjectAsParameter obj1 = new ObjectAsParameter(30);
            ObjectAsParameter obj2 = new ObjectAsParameter(20);
            if(obj1.compare(obj2))
                Console.WriteLine("first object is Greatest");
            else
                Console.WriteLine("second object is greatest");
            obj1.Add(obj2);
           obj1.putinfo();


        }
    }
}
