using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Project
{
    class Book
    {

        public int bid;
        public string bname;
        public int bprice;
        public string authorname;

    }
    class BookStore
    {
        static Book[] bookslist = new Book[4];
        static void Main(string[] args)
        {
            Book book = new Book();
            book.bid = 1;
            book.bname = "Panch tantra";
            book.bprice = 7865;
            book.authorname = "Vishnu Sharma";
            BookStore bookStore = new BookStore();
            bool res = bookStore.Insert(book);
            if (res)
            {
                Console.WriteLine("book successfully added");
            }
            else
            {
                Console.WriteLine("book not Added");
            }
            bookStore.Display();
            Book book1 = new Book();
            book1.bid = 1;
            book1.bname = "Gitagovinda";
            book1.bprice = 5434;
            book1.authorname = "jaydev";

            res =bookStore.Update(book1);
            if(res)
            {
                Console.WriteLine("book updated succesfully");
            }
            else
            {
                Console.WriteLine("book not updated");
            }
            bookStore.Display();
            res = bookStore.Delete(1);
            if(res)
            {
                Console.WriteLine("book deleted successfuly");
            }
            else
            {
                Console.WriteLine("book not deleted");
            }
            bookStore.Display();

        }

        public bool Insert(Book book)
        {
            bool result = false;
            try
            {
                for (int i = 0; i <= 4; i++)
                {
                    if (bookslist[i] == null)
                    {

                        bookslist[i] = book;
                        result = true;
                        break;
                    }
                }
                return result;
            }
            catch (IndexOutOfRangeException ex)
            {
                throw ex;
            }

        }
        public void Display()
        {
            for (int i = 0; i < 4; i++)
            {
                if (bookslist[i] != null)
                {
                    Console.WriteLine(bookslist[i].bid + "  " + bookslist[i].bname + "  "
                        + bookslist[i].bprice + "  " + bookslist[i].authorname);

                }
            }

        }
        public bool Update(Book book)
        {
            bool result = false;
            for (int i = 0; i < 4; i++)
            {
                if (bookslist[i] != null && bookslist[i].bid == book.bid)
                {
                    result = true;
                    bookslist[i] = book;
                    break;
                }

            }
            return result;
        }
        public bool Delete(int bid)
        {
            bool result = false;
            for (int i = 0; i < 4; i++)
            {
                if (bookslist[i] != null && bookslist[i].bid == bid)
                {
                    result = true;
                    bookslist[i] = null;
                    break;
                }
            }
            return result;
        }
    }
}

