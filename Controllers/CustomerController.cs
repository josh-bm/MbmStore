using MbmStore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            // create a new Customer object with instance name
            Customer customer1 = new Customer("FirstName", "LastName", "Address", "Zip", "City");

            // List
            List<Customer> customers = new List<Customer>();

            // Methods
            customer1.AddPhone("1000");
            customer1.AddPhone("2000");
            customer1.BirthDate = new DateTime(1999, 1, 1);

            customers.Add(customer1);

            // assign a ViewBag property to the new Customer object
            ViewBag.Customers = customers;

            return View();
        }
    }
}