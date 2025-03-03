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
            //properties
            string ProductID;
            string ProductName;
            double Price;

            //constroctur
            public Product(string productID, string productName, double price)
            { 
                ProductID = productID;
                ProductName = productName;
                Price = price;
            }

            //method to return ID
            public string GetProductID()
            {
                return ProductID;
            }

            //method to return Name
            public string GetProductName()
            {
                return ProductName;
            }

            //method to return Price
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
                    //calculates the total price of items
                    totalPrice += product.GetPrice();
                }
                Console.WriteLine("Total price of items in your cart: $" + totalPrice);
            }
        }
        static void Main(string[] args)
        {
            // calling for instance of ShoppingCart
            ShoppingCart cart = new ShoppingCart();

            //loop for the whole menu and their choices
            while (true)
            {
                //showing menu and the options the user can input
                Console.WriteLine("Welcome to the online shopping cart");
                Console.WriteLine("1 - Add a product to your list");
                Console.WriteLine("2 - Remove a product from your list");
                Console.WriteLine("3 - Calculate the total of your cart");
                Console.WriteLine("4 - Exit");
                Console.WriteLine("Enter your choice");

                //user inputs their choice
                string choice = Console.ReadLine();

                //different options that user can pick
                switch (choice)
                {
                    case "1":
                        //asking user input Product ID
                        Console.WriteLine("Enter Product ID: ");
                        //user inputs ID
                        string id = Console.ReadLine();

                        //asking user input for Product Name
                        Console.WriteLine("Enter Product Name: ");
                        //user inputs Name of Product
                        string name = Console.ReadLine();

                        //asking user for input Product Price
                        Console.WriteLine("Enter Product Price: ");
                        //user inputs the price
                        double price = Convert.ToDouble(Console.ReadLine());

                        //adding ID,Name, and Price to the List
                        Product newProduct = new Product(id, name, price);
                        cart.AddProduct(newProduct);
                            break;
                    case "2":
                        //asking user to input a Product ID to remove from the List
                        Console.WriteLine("Enter Product ID to Remove: ");
                        //user inputs the Product they want to remove
                        string productid = Console.ReadLine();
                        //removes the Product from the List
                        cart.RemoveProduct(productid);
                            break;
                    case "3":
                        //Showing the total price of items in the cart
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
