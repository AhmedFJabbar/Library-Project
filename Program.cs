using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newlibrary
{
    internal class Book
    {
        private string author_name;
        private string title;
        private string year;
        public string Author_name { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public Book(string author_name, string title, string year)
        {
           Author_name = author_name;
           Title = title;
            Year = year;
        }
        public void print_info()
        {
            Console.WriteLine("The title : " + Title + "\n" + "The author name : " + Author_name + "\n" + "Year of issue : " + Year);
        }
    }

    internal class Library
    {
        Book book;
        List<Book> booklist = new List<Book>();
        public void Add_book(Book book)
        {
            booklist.Add(book);
        }
        public void Search_book(string verible)
        {
            int count = 0;
            bool result = false;
            for (int i = 0; i < booklist.Count; i++)
            {
                if (booklist[i].Title == verible || booklist[i].Author_name == verible)
                {
                    Console.WriteLine("-----------------------------------");
                    count++;
                    if(count==1)
                        Console.WriteLine("\n" + "This book is avalible :" + "\n");
                    if (count >1)
                        Console.WriteLine("\n" + "and This book is avalible too :" + "\n");
                    booklist[i].print_info();
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine();
                    result = true;
                }
            }
            if (result == false)
                Console.WriteLine("\n" + "This book is not avalible" + "\n");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
         

            Library library = new Library();
            library.Add_book(new Book("ali alwardee", "farce of the human mind", "1955"));
            library.Add_book(new Book("victor hugo", "the miserables", "1862"));
            library.Add_book(new Book("voltaire", "candide", "1759"));
            library.Add_book(new Book("ali alwardee", "iraqi individual personality", "1951"));
            Console.WriteLine("Hello wellcom to the library:" + "\n");
            Console.WriteLine("Are you here to add or to search for book ?" + "\n");
            string opration = Console.ReadLine();
            opration = opration.ToLower();
            while (opration != "no")
            {
                switch (opration)
                {
                    case "add":
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine("\n" + "Enter the title of the book :");
                        string title = Console.ReadLine();
                        title = title.ToLower();
                        Console.WriteLine("Enter the author name of the book :");
                        string name = Console.ReadLine();
                        name = name.ToLower();
                        Console.WriteLine("Enter the Year of issue of the book :");
                        string year = Console.ReadLine();
                        library.Add_book(new Book(name, title, year));
                        Console.WriteLine("The book have been added successfully");
                        Console.WriteLine("-----------------------------------");
                        break;

                    case "search":
                        Console.WriteLine("Enter the title or the author name of the book:");
                        string search = Console.ReadLine();
                        search = search.ToLower();
                        library.Search_book(search);
                        break;

                    default:
                        Console.WriteLine("\n" + "The input should be 'add' or 'search' :");
                        break;
                }
                  input:
                    Console.WriteLine("\n" + "Do you want to repet the prossec yes or no  :");
                    opration = Console.ReadLine();
                    opration = opration.ToLower();
                    switch (opration)
                    {
                        case "yes":
                            Console.Clear();
                            Console.WriteLine("\n" + "Welcom agine you want to 'add' or 'search' :");
                            opration = Console.ReadLine();
                            opration = opration.ToLower();
                            break;
                        case "no":
                            Console.Clear();
                            Console.WriteLine("\n" + "Welcom any time and take care :");
                            break;
                        default:
                            Console.WriteLine("the input should be 'yes' or 'no' :");
                            goto input;
                    }
            }
            Console.ReadLine();
        }
    }
}
