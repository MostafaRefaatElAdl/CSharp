using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateOnly PublicationDate { get; set; }
        public decimal Price { get; set; }
        public Book(string _ISBN, string _Title,
        string[] _Authors, DateOnly _PublicationDate,
        decimal _Price)
        {
            ISBN = _ISBN;
            Title = _Title;
            Authors = _Authors;
            PublicationDate = _PublicationDate;
            Price = _Price;
        }
        public virtual string GetAuthorsToStr(string[] arr)
        {
            string res = "";
            for (int i = 0; i < arr.Length; i++)
            {
                res+=$"{arr[i] + ", "}";

            }
            return res;
        }

        public override string ToString() => $"ISBN: {ISBN} \n" +
            $"Title: {Title}\n" +
            $"Publication Date: {PublicationDate} \n" +
            $"Authors: {GetAuthorsToStr(Authors)}\n" +
            $"Price: {Price}\n\n";

    }
}
