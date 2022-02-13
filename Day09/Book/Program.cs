using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public delegate string uDDelegate(Book b);
    internal class Program
    {
        static void Main()
        {

            uDDelegate ptr = BookFunctions.GetAuthors;
            Func<Book, string> funcTest = BookFunctions.GetPrice;

            Func<Book, string> Anonymous = delegate (Book b)
            {
                return $"PublicationDate : {b.PublicationDate}";
            };

            //Func<Book, string> (B)=> $"ISBN : {B.ISBN}";


            Book Nature = new ("4515", "Nature", new string[] { "Someone", "AA" }, new DateOnly(2009,4,15), 250);
            Book WhatsLife = new ("3443", "WhatsLife", new string[] { "Another", "NoOne" }, new DateOnly(2005,5,17), 150);
            Book Happness = new ("2342", "Happness", new string[] { "Someone", "sss" }, new DateOnly(2001,1,2), 300);
            Book CSharp = new ("5654", "C#", new string[] { "Someone", "Test" }, new DateOnly(2015,3,28), 250);
            List<Book> books = new ();
            books.Add(Nature);
            books.Add(WhatsLife);
            books.Add(Happness);
            books.Add(CSharp);
            LibraryEngine.ProcessBooks(books, ptr);
            Console.WriteLine("================================");
            LibraryEngine.ProcessBooksForFunc(books, funcTest);
            Console.WriteLine("================================");
            LibraryEngine.ProcessBooksForFunc(books, Anonymous);
            Console.WriteLine("================================");
            LibraryEngine.ProcessBooksForFunc(books, (B) => $"PublicationDate : {B.PublicationDate}");
        }
    }
}