using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Movie : Product
    {
        // properties

        public string Director { get; set; }

        public short Released { get; set; }

        // constructors
        public Movie() { }

        public Movie(string title, decimal price)
        {
            Title = title;
            Price = price;
        }

        public Movie(string title, string director, decimal price, string imageFileName)
        {
            Title = title;
            Director = director;
            Price = price;
            ImageFileName = imageFileName;
        }
    }
}