using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk7Ex3
{
    internal class Program
    {
        public class Product
        {
            string ProductID;
            string ProductName;
            double Price;

            public Product(string productID, string productName, double price)
            { 
                ProductID = productID;
                ProductName = productName;
                Price = price;
            }

            public string GetProductID()
            {
                return ProductID;
            }

            public string GetProductName()
            {
                return ProductName;
            }

            public double GetPrice()
            {
                return Price;
            }
        }

        public class ShoppingCart
        {
            // List of products
            static List<Product> items = new List<Product>();

            // method to add product to the cart
            public void AddProduct(Product product)
            {
                items.Add(product);
                Console.WriteLine(product.GetProductName() + " has been added to your cart.");
            }
            // method to remove item from cart by its id
            public void RemoveProduct(string productid)
            {
                Product productRemove = null;
                // Find product by ID
                foreach (var product in items)
                {
                    if (product.GetProductID() == productid)
                    {
                        productRemove = product;
                        break;
                    }
                }

                if (productRemove != null)
                {
                    items.Remove(productRemove);
                    Console.WriteLine(productRemove.GetProductName() + " has been removed from your cart.");
                }
                else
                {
                    Console.WriteLine("Product not found in the cart.");
                }
            }
            // method to return the total price of the products in the cart
            public void CalculateTotalPrice()
            { 
                double totalPrice = 0;

                foreach (var product in items)
                {
                    totalPrice += product.GetPrice();
                }
                Console.WriteLine("Total price of items in your cart: $" + totalPrice);
            }
        }
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();
            while (true)
            {
                Console.WriteLine("Welcome to the online shopping cart");
                Console.WriteLine("1 - Add a product to your list");
                Console.WriteLine("2 - Remove a product from your list");
                Console.WriteLine("3 - Calculate the total of your cart");
                Console.WriteLine("4 - Exit");
                Console.WriteLine("Enter your choice");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter Product ID: ");
                        string id = Console.ReadLine();
                        Console.WriteLine("Enter Product Name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter Product Price: ");
                        double price = Convert.ToDouble(Console.ReadLine());

                        Product newProduct = new Product(id, name, price);
                        cart.AddProduct(newProduct);
                            break;
                    case "2":
                        Console.WriteLine("Enter Product ID to Remove: ");
                        string productid = Console.ReadLine();
                        cart.RemoveProduct(productid);
                            break;
                    case "3":
                        cart.CalculateTotalPrice();
                            break;
                    case "4":
                        Console.WriteLine("Thanks for ordering from us");
                        return;
                }
            }
        }
    }
}
