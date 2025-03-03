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

            
        }

        public class ShoppingCart
        {
            // List of products
            static List<int> Items = new List<int>();

            // method to add product to the cart
            public void AddProduct(Product product)
            { 
            
            }
            // method to remove item from cart by its id
            public void RemoveProduct(string productid)
            {
            
            }
            // method to return the total price of the products in the cart
            public void CalculateTotalPrice()
            { 
            
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to the online shopping cart");
                Console.WriteLine("1 - Add a product to your list");
                Console.WriteLine("2 - Remove a product from your list");
                Console.WriteLine("3 - Calculate the total of your cart");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddProduct(Product product);
                            break;
                    case "2":
                        RemoveProduct(string productid);
                            break;
                    case "3":
                        CalculateTotalPrice();
                            break;
                    case "4":
                        Console.WriteLine("Thanks for ordering from us");
                        return;
                }
            }
        }
    }
}
