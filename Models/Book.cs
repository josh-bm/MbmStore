using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Book : Product
    {
        // properties

        public string Author { get; set; }

        public string Publisher { get; set; }

        public short Published { get; set; }

        public string ISBN { get; set; }

        // constructors
        public Book() { }

        public Book(string author, string title, decimal price, short published)
        {
            Author = author;
            Title = title;
            Price = price;
            Published = published;
        }
    }
}