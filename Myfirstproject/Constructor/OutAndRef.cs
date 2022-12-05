using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Constructor
{
    class OutAndRef
    {
        public static string GetNextName(ref int id)
        {
            string returnText = "Next=" + id.ToString();
            id += 1;
            return returnText;
        }
/*        public static string GetNextName(out int id)
        {
            
            id= 1;
            string returnText = "Next=" + id.ToString();
            return returnText;
        }*/
        static void Main(string[] args)
        {
           
            int a = 5;
            GetNextName(ref a);
           // GetNextName(out a);
        }
    }
}
