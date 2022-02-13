using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public class LibraryEngine
    {
        public static void ProcessBooks(List<Book> bList, uDDelegate fptr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine($"{BookFunctions.GetTitle(B)} => {fptr(B)}");
            }
        }

        public static void ProcessBooksForFunc(List<Book> bList, Func<Book,string> fptr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine($"{BookFunctions.GetTitle(B)} => {fptr(B)}");
            }
        }
    }
}
