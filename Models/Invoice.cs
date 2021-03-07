using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Invoice
    {
        // fields
        private decimal totalPrice;

        private List<OrderItem> orderItems = new List<OrderItem>();

        // properties
        public int InvoiceId { get; set; }

        public DateTime OrderDate { get; set; }

        public Customer Customer { get; set; }

        //readonly

        public decimal TotalPrice
        {
            get
            {
                foreach (OrderItem orderItem in OrderItems)
                {
                    totalPrice += orderItem.Product.Price;
                }
                return totalPrice;
            }
        }

        public List<OrderItem> OrderItems { get { return orderItems; } }

        // constructors
        public Invoice() { }

        public Invoice(int invoiceId, DateTime orderDate, Customer customer)
        {
            InvoiceId = invoiceId;
            OrderDate = orderDate;
            Customer = customer;
        }

        // methods
        public void AddOrderItem(Product product, int quantity)
        {
            orderItems.Add(new OrderItem(product, quantity));
        }
    }
}