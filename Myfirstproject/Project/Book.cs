using System;
using System.Collections;
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
        //static Book[] bookslist = new Book[4];
        static List<Book> bookslist = new List<Book>();
        static void Main(string[] args)
        {
            BookStore bookStore = new BookStore();
            Console.WriteLine("\t\nCRUD Operations : \nPress 1 To Insert Data\nPress 2 To Update Data" +
                $"\nPress 3 To Delete Data\nPress 4 To DisplayData\nPress 5 To Exit\n ");
            bool ToStop = false;
            do
            {

                /*Console.WriteLine("\nCRUD Operations : \nPress 1 To Insert Data\nPress 2 To Update Data" +
                 $"\nPress 3 To Delete Data\nPress 4 To DisplayData\nPress 5 To Exit\n ");
*/
                Console.WriteLine("\nEnter the choice");
                int no = int.Parse(Console.ReadLine());
                Book book = new Book();
                switch (no)
                {

                    case 1:

                        Console.WriteLine("\n 1.Insert Operation");
                        bool res1 = bookStore.Insert(book);
                        Console.WriteLine("Enter the book id");
                        book.bid = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the book name");
                        book.bname = Console.ReadLine();
                        Console.WriteLine("Enter the book price");
                        book.bprice = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the book author name");
                        book.authorname = Console.ReadLine();

                        if (res1)
                        {
                            Console.WriteLine("book successfully added");
                        }
                        else
                        {
                            Console.WriteLine("book not Added");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Update Operation");
                        Console.WriteLine("enter the book id for update");
                        Book book1 = new Book();
                        book1.bid = int.Parse(Console.ReadLine());
                        bookStore.FetchData(book1.bid);
                        Console.WriteLine("\n\t\t\t\tPress 1 To Update Book Name\n\t\t\t\tPress 2 To Update Book Price" +
                            $"\n\t\t\t\tPress 3 To Update Book Author Name");

                        Console.Write("Enter here..");
                        int key = int.Parse(Console.ReadLine());
                        switch (key)
                        { 

                            case 1:
                                Console.WriteLine("Enter book name for replace");
                                book1.bname = Console.ReadLine();
                                bookStore.Update(book1);
                                break;
                            case 2:
                                Console.WriteLine("Enter the book price for replace");
                                book1.bprice = int.Parse(Console.ReadLine());
                                bookStore.Update(book1);
                                break;
                            case 3:
                                Console.WriteLine("Enter the author name for replace");
                                book1.authorname = Console.ReadLine();
                                bookStore.Update(book1);
                                break;

                        }

                        /* // Console.WriteLine("enter the book name");
                         // book1.bname = Console.ReadLine();
                         Console.WriteLine("enter the book price");
                         book1.bprice = int.Parse(Console.ReadLine());
                        // Console.WriteLine("enter the author name");
                         book1.authorname = Console.ReadLine();*/
                        bool res = bookStore.Update(book1);
                        if (res)
                        {
                            Console.WriteLine("book updated succesfully");
                        }
                        else
                        {
                            Console.WriteLine("book not updated");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Delete Operation");
                        Console.WriteLine("enter the id for delete");
                        int id = int.Parse(Console.ReadLine());
                        res = bookStore.Delete(id);
                        if (res)
                        {
                            Console.WriteLine("book deleted successfuly");
                        }
                        else
                        {
                            Console.WriteLine("book not deleted");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Dispaly Operation");
                        bookStore.Display();
                        break;

                    case 5:
                        Console.WriteLine("Exit");
                        ToStop = true;
                        break;

                    default:
                        Console.WriteLine("Invalid key");
                        break;

                }

            } while (!ToStop);

        }

        public bool Insert(Book book)
        {

            bool result = false;

            bookslist.Add(book);
            result = true;
            return result;


        }
        public void Display()
        {
            for (int i = 0; i < bookslist.Count; i++)
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
            for (int i = 0; i < bookslist.Count; i++)
            {
                if (bookslist[i] != null && bookslist[i].bid == book.bid)
                {
                    result = true;
                    if (!string.IsNullOrEmpty(book.bname))
                    {
                        bookslist[i].bname = book.bname;
                    }
                    if (book.bprice != 0)
                    {
                        bookslist[i].bprice = book.bprice;
                    }
                    if(!string.IsNullOrEmpty(book.authorname))
                    {
                        bookslist[i].authorname = book.authorname;
                    }

                    break;
                }

            }
            return result;
        }
        public bool Delete(int bid)
        {
            bool result = false;
            for (int i = 0; i < bookslist.Count; i++)
            {
                if (bookslist[i] != null && bookslist[i].bid == bid)
                {
                    result = true;
                    bookslist.RemoveAt(i);
                    break;
                }
            }
            return result;
        }
        public void FetchData(int bid)
        {
            bool result = false;
            for(int i=0;i<bookslist.Count;i++)
            {

                if (bookslist[i].bid == bid)
                {
                    result = true;
                    Console.WriteLine(bookslist[i].bid + "  " + bookslist[i].bname + "  "
                        + bookslist[i].bprice + "  " + bookslist[i].authorname);
                }
            }
            if(result==false)
            {
                Console.WriteLine("book not found of this id");
            }
        }




    }
}
