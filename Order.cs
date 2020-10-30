using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public class Order
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }

        public Order() { }


    }
}





/*using Catalog;
using CRM;
using ShoppingCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        private Customer TheCustomer { get; set; }
        private List<Item> items = new List<Item>();

      

        public Order(int OrderId,DateTime OderDate, Customer TheCustomer, Item items)
        {
            this.OrderId = OrderId;
            this.OrderDate = OrderDate;
          
        
        
        
        }
    }
}

using ShoppingCart;
using CRM;
using System;
using System.Collections.Generic;

namespace OrderProcessing
{
    public class Order
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public Customer theCustomer { get; set; }
        public List<Item> Items = new List<Item>();

        public Order() { }
        public Order(int orderId, DateTime orderDate, Customer theCustomer, List<Item> items)
        {
            this.OrderID = orderId;
            this.OrderDate = orderDate;
            this.theCustomer = theCustomer;
            Items = items;
        }
        public override string ToString()
        {
            return "Order Details\n" + "Order ID: " + OrderID + "\n" + "Order Date: " + OrderDate + "\n" + "\nCustomer Details\n" + theCustomer;
        }
    }
}

*/