using System;

namespace LibraryBookTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Cinayət və Cəza", "Fyodor Mixayloviç Dostoyevski", 800, "Fəlsəfi Psixoloji Roman",1866);
            Book book2=new Book("Yad", "Albert Kamu", 450,"Fəlsəfi  Roman", 1942);
            Book book3=new Book("Zərdüşt belə deyirdi", "Fridrix Nitşse", 350,"Fəlsəfi  Roman", 1883);

            LIbrary lIbrary=new LIbrary("Baku Book Center" ,"Baki 1009");
            lIbrary.AddBook(book);
            lIbrary.AddBook(book2);
            lIbrary.AddBook(book3);
            //lIbrary.RemoveBook(book);
            lIbrary.RemoveBook(book2);
            //lIbrary.RemoveBook(book2);
            //lIbrary.GetBooks();
            lIbrary.GetAllDetaails();
        }
    }
}
