using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.AssignmentOnException
{
    //WAP to create user defined Exception raise and catch the exception

    public class FitnessTestFailedException : Exception
    {
        public FitnessTestFailedException(string message) : base(message)
        {
        }
    }
    class Fitness
    {
        int points = 0;

        public void showResult()
        {

            if (points < 110)
            {
                throw (new FitnessTestFailedException("Player failed the fitness test!"));
            }
            else
            {
                Console.WriteLine("Player passed the fitness test!");
            }
        }
    }
    class TestFitness
    {
        static void Main(string[] args)
        {
            Fitness f = new Fitness();
            try
            {
                f.showResult();
            }
            catch (FitnessTestFailedException e)
            {
                Console.WriteLine("User defined exception: {0}", e.Message);
            }
            Console.ReadKey();
        }
    }

    //WAP to create custom Exception and show use of throw keyword

    class NotAllowedDigitException : SystemException
    {
        public NotAllowedDigitException()
        {
            Console.WriteLine("Length is not valid");
        }
    }
    class customDemo2
    {
        public static void check(string s)
        {
            bool ispresent = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                {
                    ispresent = true;
                    break;

                }
            }
            if (ispresent == true)
            {
                throw new NotAllowedDigitException();
            }
            Console.WriteLine("valid string");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string s = Console.ReadLine();
            try
            {
                check(s);
            }
            catch (NotAllowedDigitException e)
            {
                Console.WriteLine("handle....");
            }
        }
    }
    // WAP which throws IndexOutOfRangeException. In the console, observe the stack trace and the line number from where the Exception is thrown

    class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = new int[5];
            try
            {

                for (int i = 0; i < 8; i++)
                {
                    intArr[i] = i;
                    Console.WriteLine("arr[{0}]: {1}", i, intArr[i]);
                }
                Console.WriteLine("Exception occured");
            }
            catch (IndexOutOfRangeException e)
            {

                Console.WriteLine("\n ERROR :" + e.StackTrace);

            }
            finally
            {
                Console.WriteLine("Finally block.");
            }
            Console.WriteLine("After finally block.");
            Console.ReadLine();
        }
    }
    //WAP to use catch / handle the IndexOutOfRangeException exception. 
    class ExceptionDemo
    {
        static void Main(string[] args)
        {
            int[] Array = new int[5] { 50, 40, 30, 20, 10 };

            int sum = 0;

            try
            {
                for (int i = 0; i <= 5; i++)
                {
                    sum += Array[i];
                }
                Console.WriteLine("Sum of array elements:" + sum);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    //WAP to catch multiple exceptions. i.e IndexOutOfRangeException, NullReferenceException
    // and DivideByZeroException.

    class MultiCatch
    {
        static void Main(string[] args)
        {
            int sum = 0;
            try
            {
                int[] a = new int[3];
                Console.WriteLine(a[4] / sum);

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("........." + e.ToString());
            }
            catch (IndexOutOfRangeException e1)
            {
                Console.WriteLine("........." + e1.ToString());
            }
            catch (Exception e2)
            {
                Console.WriteLine(e2.ToString() + "........");
            }

        }
    }
    class Program34
    {
        static public void Main()
        {
            int number = 4;
            int divisor = 0;

            try
            {
                int result = number / divisor;
            }

            catch (DivideByZeroException)
            {

                Console.WriteLine("Not possible to divide by zero");
            }
            finally
            {

                Console.WriteLine("Finally Block!");
            }
        }
    }
}
