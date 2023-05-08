using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Inventory
{
    internal class Movie
    {
        public string Title;
        public string Director;
        public int ReleaseYear;
        public double Price;

        public Movie(string title, string director, int releaseyear, double price)
        {
            Title = title;
            Director = director;
            ReleaseYear = releaseyear;
            Price = price;
        }

        public string bookSummary()
        {
            return ($"{Title} was directed by {Director} and released in {ReleaseYear}.");
        }

        public string bookPrice()
        {
            return ($"{Title} costs {Price}.");
        }
    }
}
