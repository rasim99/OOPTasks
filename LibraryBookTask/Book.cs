using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryBookTask
{
    internal class Book
    {
        public Book(string name, string authorName, int pageCount, string genre,int year)
        {
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
            Genre = genre;
            PublisingDate = new DateTime(year,1,1);
        }
        public DateTime PublisingDate { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public string Genre { get; set; }
    }
}
