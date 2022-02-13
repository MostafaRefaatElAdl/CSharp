using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public class BookFunctions
    {
        public static string GetISBN(Book B) => $"ISBN : {B.ISBN}";
        public static string GetTitle(Book B) => B.Title;
        public static string GetAuthors(Book B) => $"Authors : {B.GetAuthorsToStr(B.Authors)}";
        public static string GetPrice(Book B) => $"{B.Price}$";
        public static string GetPublicationDate(Book B) => $"PublicationDate : {B.PublicationDate.ToString()}";
    }

}
