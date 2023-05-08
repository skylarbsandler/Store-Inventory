using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Inventory
{
    internal class Book
    {
        public string Title;
        public string Author;
        public int PublicationYear;
        public double Price;

        public Book(string title, string author, int publicationyear, double price)
        {
            Title = title;
            Author = author;
            PublicationYear = publicationyear;
            Price = price;
        }

        public string bookSummary()
        {
            return ($"{Title} was written by {Author} in {PublicationYear}.");
        }

        public string bookPrice()
        {
            return ($"{Title} by {Author} costs {Price}.");
        }

    }
}
