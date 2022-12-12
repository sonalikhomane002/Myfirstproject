using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.AbstractEx
{

    //interface example
    public interface IAccept
    {
        public abstract int AcceptValue(int x);

    }


    class Factor : IAccept
    {
        public int AcceptValue(int x)
        {
            int sum = 0;
            for(int i=1;i<=x/2;i++)
            {
                
                    if(x%i==0)
                    {
                        Console.WriteLine(i);
                        sum = sum + i;
                    }
                
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Factor f = new Factor();
            f.AcceptValue(5);
        }
    }







}
