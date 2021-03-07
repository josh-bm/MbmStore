using MbmStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Infrastructure
{
    public static class Repository
    {
        // List of products and invoices
        public static List<Product> Products = new List<Product>();

        public static List<Invoice> Invoices = new List<Invoice>();

        public static List<Customer> Customers = new List<Customer>();

        // constructors
        static Repository()
        {
            // Books
            Book book1 = new Book("Steve Turner", "A Hard Day's Write: The Stories Behind Every Beatles Song", 18, 2005);
            book1.ImageFileName = "beatles-book.jpg";
            book1.ISBN = "0060844094";
            Products.Add(book1);

            // Music CDs
            MusicCD cd1 = new MusicCD("The Beatles", "Abbey Road(Remastered)", 19, 1969);
            cd1.ImageFileName = "beatles-cd.jpg";
            cd1.AddTrack(new Track("Come Together", "Composer", new TimeSpan(1, 1, 1)));
            cd1.AddTrack(new Track("Something", "Composer", new TimeSpan(1, 1, 1)));
            cd1.AddTrack(new Track("Come Together", "Composer", new TimeSpan(1, 1, 1)));
            cd1.AddTrack(new Track("Come Together", "Composer", new TimeSpan(1, 1, 1)));
            cd1.AddTrack(new Track("Come Together", "Composer", new TimeSpan(1, 1, 1)));
            cd1.AddTrack(new Track("Come Together", "Composer", new TimeSpan(1, 1, 1)));
            cd1.AddTrack(new Track("Come Together", "Composer", new TimeSpan(1, 1, 1)));
            cd1.AddTrack(new Track("Come Together", "Composer", new TimeSpan(1, 1, 1)));
            cd1.AddTrack(new Track("Come Together", "Composer", new TimeSpan(1, 1, 1)));
            cd1.AddTrack(new Track("Come Together", "Composer", new TimeSpan(1, 1, 1)));
            cd1.AddTrack(new Track("Come Together", "Composer", new TimeSpan(1, 1, 1)));
            cd1.AddTrack(new Track("Come Together", "Composer", new TimeSpan(1, 1, 1)));
            cd1.AddTrack(new Track("Come Together", "Composer", new TimeSpan(1, 1, 1)));
            cd1.AddTrack(new Track("Come Together", "Composer", new TimeSpan(1, 1, 1)));
            cd1.AddTrack(new Track("Come Together", "Composer", new TimeSpan(1, 1, 1)));

            Products.Add(cd1);

            // Movies
            Movie jungleBook = new Movie("Jungle Book", "Jon Favreau", 160.50m, "junglebook.jpg");
            Movie forrestGump = new Movie("Forrest Gump", "Robert Zemeckis", 160.50m, "forrest-gump.jpg");
            Movie gladiator = new Movie("Gladiator", "Ridley Scott", 160.50m, "gladiator.jpg");

            Products.Add(jungleBook);
            Products.Add(forrestGump);
            Products.Add(gladiator);

            // Customers
            Customer customer1 = new Customer("FirstName", "LastName", "Address", "Zip", "City");
            Customer customer2 = new Customer("FirstName", "LastName", "Address", "Zip", "City");

            Customers.Add(customer1);
            Customers.Add(customer2);

            // Invoice
            Invoice invoice1 = new Invoice(1, new DateTime(2000, 01, 01), customer1);
            Invoice invoice2 = new Invoice(2, new DateTime(2000, 01, 01), customer2);

            invoice1.AddOrderItem(book1, 1);
            invoice1.AddOrderItem(gladiator, 1);

            invoice2.AddOrderItem(cd1, 1);
            invoice2.AddOrderItem(jungleBook, 1);

            Invoices.Add(invoice1);
            Invoices.Add(invoice2);
        }
    }
}