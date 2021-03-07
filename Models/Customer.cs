using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Customer
    {
        // fields
        private DateTime birthDate;

        private List<string> phoneNumbers = new List<string>();

        // properties
        public int CustomerId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }

        // read only property

        public List<string> PhoneNumbers
        {
            get
            {
                return phoneNumbers;
            }
        }

        public int Age
        {
            get
            {
                DateTime now = DateTime.Now;
                int age;
                age = now.Year - birthDate.Year;
                if (now.Month < birthDate.Month ||
                    (now.Month == birthDate.Month && now.Day < birthDate.Day)
                    )
                {
                    age--;
                }
                return age;
            }
        }

        // property that validates input
        public DateTime BirthDate
        {
            set
            {
                if ((DateTime.Now.Year - value.Year) > 120 ||
                (DateTime.Now.Year - value.Year) < 0)
                {
                    throw new Exception("Age is not accepted");
                }
                else
                {
                    birthDate = value;
                }
            }

            get { return birthDate; }
        }

        public List<Invoice> Invoices = new List<Invoice>();

        // constructors
        public Customer() { }

        public Customer(string firstName, string lastName, string address, string zip, string city)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.Zip = zip;
            this.City = city;
        }

        // methods
        public void AddPhone(string phone)
        {
            phoneNumbers.Add(phone);
        }

        public void AddInvoice(Invoice invoice)
        {
        }
    }
}