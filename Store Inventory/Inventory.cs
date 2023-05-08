using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Inventory
{
    internal class Inventory
    {
        public string Name;
        public List<Book> Books = new List<Book>();
        public List<Movie> Movies = new List<Movie>();

        public Inventory(string name)
        {
            Name = name;
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void AddMovie(Movie movie)
        {
            Movies.Add(movie);
        }

        public string BookInventoryTotalPrice()
        {
            double booktotalPrice = 0.0;

            foreach(var book in Books)
            {
                booktotalPrice += book.Price;
            }

            return ($"The total sales values of the books currently in inventory is ${booktotalPrice}.");
        }

        public string MovieInventoryTotalPrice()
        {
            double movietotalPrice = 0.0;

            foreach (var movie in Movies)
            {
                movietotalPrice += movie.Price;
            }

            return ($"The total sales values of the books currently in inventory is ${movietotalPrice}.");
        }
    }
}
