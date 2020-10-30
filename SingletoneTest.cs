using System;
using System.Collections.Generic;
using Catalog;
using ShoppingCart;
using OrderProcessing;
using CRM;

namespace TesterApp
{
    class SingletonTest
    {
        public static IEnumerable<PurchaseOrder> Orders { get; private set; }

        static void Main(string[] arg)
        {
            PurchaseManager mgr1, mgr2, mgr3;

            mgr1 = PurchaseManager.GetManager();
            mgr2 = PurchaseManager.GetManager();
            mgr3 = PurchaseManager.GetManager();




            Product product1 = new Product(1, "Rose", "Valentine flower", 10, 400);
            Product product2 = new Product(2, "Marigold", "Festival flower", 5, 500);

            Item item1 = new Item(product1, 34);
            Item item2 = new Item(product2, 56);

            Cart cart1 = new Cart();

            cart1.AddToCart(item1);
            cart1.AddToCart(item2);
            List<Item> items = new List<Item>();
            items.Add(item1);
            items.Add(item2);
            List<Item> cartItems = cart1.Items;
            DateTime ordDate = DateTime.Now;
            Customer customer1 = new Customer
            {
                UserID = "100",
                FullName = "Arun Surase",
                Email = "arun@gmail.com",
                ContactNubmer = "9689607171",
                Location = "Pune",
                Password = "seed"
            };
            Order theOrder = new PurchaseOrder(1001, ordDate, customer1, cartItems);


            mgr1.Orders = new List<Order>();
            mgr1.Orders.Add(theOrder);

            int count = mgr2.Orders.Count;
            Console.WriteLine(count);
            Console.WriteLine(mgr1);

            foreach (PurchaseOrder or in mgr2.Orders)
            {

                Console.WriteLine(or.OrderID);
                Console.WriteLine(or.OrderDate);
                foreach(Item o in items)
                {
                    Console.WriteLine(o.theProduct);
                    Console.WriteLine(o.Quantity);

                }
            }


            Console.ReadLine();
        }





    }
}
