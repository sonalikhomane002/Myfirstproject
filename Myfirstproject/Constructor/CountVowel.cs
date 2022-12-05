using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Constructor
{
    class CountVowel
    {
        static void Main(string[] args)
        {
            string str = "Hello World";

            Console.WriteLine("String is="+str);

            int count = 0;
            for(int i=0;i<str.Length;i++)
            {
                if(str[i]=='a'||str[i]=='e'||str[i]=='i'||str[i]=='o'||str[i]=='u'||str[i]=='A'||str[i]=='E'||str[i]=='I'||str[i]=='O'||str[i]=='U')
                {
                    count++;
                }

            }
            Console.WriteLine("No of vowel in String="+count);
        }
    }
}
