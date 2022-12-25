using System;

namespace Myfirstproject.ExceptionDemo
{
    class Class1

    {
        static string s;
        static void Main(string[] args)
        {
            try
            {
                if (s == null)
                {
                    throw new Exception();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Handeled..." + e.ToString());
            }
            Console.WriteLine("hi.......");
        }
    }
    class TestExcception
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            int sum = 0;
            try
            {
                int x = 10 / sum;
                Console.WriteLine("xxx" + x);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Handled...." + e.ToString());
            }
            Console.WriteLine("Hi");
            Console.WriteLine("Good");
        }
    }
    class TestException2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            int sum = 0;
            try
            {
                int y = 10 / sum;
                Console.WriteLine("xxx" + y);

            }
            catch (Exception)
            {
                Console.WriteLine("Handled");
            }
            Console.WriteLine("Hi");
            Console.WriteLine("Good");
        }
    }
    class TestException3
    {

        static void Main(string[] args)
        {
            int[] a = { 5, 6, 7 };

            try
            {
                a[4] = 89;
            }
            catch (Exception)
            {
                Console.WriteLine("Handle");
            }
            Console.WriteLine("Done");
        }
    }
    //try catch finally block
    class ExceptionTest4
    {
        static void Main(string[] args)
        {
            int sum = 0;
            try
            {
                Console.WriteLine(10 / sum);
            }
            catch
            {
                Console.WriteLine("Handle");
            }
            finally
            {
                Console.WriteLine("finally Executed");
            }
        }
    }
    class ExceptionDemo6
    {
        static void Main(string[] args)
        {
            int sum = 2;

            try
            {
                Console.WriteLine(10 / sum);
            }
            finally
            {
                Console.WriteLine("finally executed");

            }
            Console.WriteLine("hii");
        }

    }
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
    class ThrowDemo
    {
        public static void check(int age)
        {
            if (age < 18)
            {
                throw new Exception("Invalid age for Driving ");
            }
            else
            {
                Console.WriteLine("age is valid for Driving test.......");
            }
            Console.WriteLine("hii");
        }
        static void Main(string[] args)
        {
            try
            {
                ThrowDemo.check(20);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("good");
        }
    }
    class Task
    {
        static void Main(string[] args)
        {
            int count = 0;
            try
            {

                count++;
                try
                {
                    count++;

                    try
                    {
                        count++;
                        throw new Exception();
                    }
                    catch (Exception e1)
                    {
                        count++;
                        throw e1;
                    }
                }
                catch (Exception e)
                {
                    count++;
                    throw e;
                }
            }
            catch
            {
                Console.WriteLine(count);
            }

        }
    }
    //custom exception Example.
    class NotBinaryNumberException : SystemException
    {
        public NotBinaryNumberException()
        {
            Console.WriteLine("NotBinaryNumberException");
        }
        public NotBinaryNumberException(string s) : base(s)
        {

        }
    }
    class Test
    {
        public static void check(string s)
        {
            bool ispresent = false;
            for (int i = 0; i < s.Length; i++)
            {

                if (s[i] != '0' && s[i] != '1')
                {
                    ispresent = true;
                    break;

                }

            }
            if (ispresent == true)
            {
                throw new NotBinaryNumberException();
            }
            Console.WriteLine("valid Number");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the Number");
            string s = Console.ReadLine();
            try
            {
                check(s);

            }
            catch
            {
                Console.WriteLine("handle");
            }
        }
    }
    //custom exception Example2.

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
            Console.WriteLine("enter the string");
            string s = Console.ReadLine();
            try
            {
                check(s);
            }
            catch(NotAllowedDigitException e)
            {
                Console.WriteLine("handle....");
            }
        }
    }
    class Program99
    {
        static void Main(string[] args)
        {
            string str = null;
            try
            {
                Console.WriteLine(str.Substring(5));
            }
            catch (NullReferenceException err)
            {
                Console.WriteLine("Please check the string str.");
                Console.WriteLine(err.Message);
            }
            Console.WriteLine("Continuing with other statments..");
        }
    }
    class AlphabetNotAllowedException : SystemException
    {
        public AlphabetNotAllowedException()
        {
            Console.WriteLine("Alphabet not allowed in Number");


        }
    }
    class LengthNotValidException : SystemException
    {
        public LengthNotValidException()
        {
            Console.WriteLine("Length is not valid");
        }
    }


    class CustomDemo9
    {
        public static void check(string s)
        {

            for (int i = 0; i < s.Length; i++)
            {
                if (!char.IsDigit(s[i]))
                {
                    throw new AlphabetNotAllowedException();
                }
            }
            if (s.Length != 10)
            {
                throw new LengthNotValidException();
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string s = Console.ReadLine();

            try
            {
                check(s);
            }
            catch(AlphabetNotAllowedException)
            {
                Console.WriteLine(".handle........");
            }
            catch(LengthNotValidException)
            {
                Console.WriteLine(".handle2........");
            }


        }
    }
}