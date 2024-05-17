using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryBookTask
{
    internal class LIbrary
    {
        public Book[] books;
        public Book []Books { get=>books;}
        public string Name { get; set; }
        public string Location { get; set; }
        public int MaxBookCapasity { get; }
        public LIbrary(string name,string location)
        {
            Name = name;
            Location = location;
            MaxBookCapasity = 100;
            books= new Book[0];
        }

        public void AddBook(Book book)
        {
            if (MaxBookCapasity>books.Length)
            {
                Array.Resize(ref books, books.Length + 1);
                books[books.Length - 1] = book;
            }
            else
            {
                Console.WriteLine("bosh yer qalmayib");
            }
        }
         public void RemoveBook(Book book)
        {
            int index=Array.IndexOf(books, book);
            if (index != -1)
            {
                for (int i = index; i < books.Length-1; i++)
                {
                    books[i] = books[i + 1]; 
                }
                Array.Resize(ref books, books.Length-1);
            }
            else
            {
                Console.WriteLine("kitab tapilmadi");
            }
        }

        public void GetBooks()
        {
            foreach (Book book in books)
            {
                Console.WriteLine($"BookName :  {book.Name}  AuthorName :  {book.AuthorName}" +
                    $"Genre  :  {book.Genre}   PageCount :  {book.PageCount} " +
                    $"PublisingDate  : {book.PublisingDate.Year}");

            }
        }

        public void GetAllDetaails()
        {
            GetBooks();
            Console.WriteLine($"LibraryName  : {Name} Location  : {Location}" +
                $" Capasity  : {MaxBookCapasity}");
        }
    }
}
