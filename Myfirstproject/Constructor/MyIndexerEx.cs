using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Constructor
{
    class MyIndexerEx
    {
        int[] count = new int[5];

        public int this[int i]
        {
            get { return count[i]; }
            set { count[i] = value; }
        }
        static void Main(string[] args)
        {
            MyIndexerEx obj = new MyIndexerEx();
            obj[0] = 10;
            obj[1] = 20;
            obj[2] = 30;
            obj[3] = 40;
            obj[4] = 50;

            for(int i=0;i<5;i++)
                Console.WriteLine(obj[i]+" ");
            Console.ReadKey();
        }

    }
}
