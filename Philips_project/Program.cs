using Philips_Project.Model;
using Philips_Project.Services;
using System;
using System.Collections.Generic;

namespace Philips_Project 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var service = new ShoppingCartService();
            while(true)
            {
                Console.WriteLine("Choose your action and type the number");
                Console.WriteLine("1. Add item to cart");
                Console.WriteLine("2. View items in cart");
                Console.WriteLine("3. Exit");

                string input = Console.ReadLine();
                if (int.TryParse(input, out int choice))
                {
                    switch(choice)
                    {
                        case 1:
                            AddItemToCart(service);
                            break;
                        case 2:
                            ViewItemsInCart(service);
                            break;
                        case 3:
                            return;

                        default:
                            Console.WriteLine("Invalid choice. Please try again!");
                            break;
                    }
                } 
                else 
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }

                
            }
        }

        private static void AddItemToCart(ShoppingCartService service)
        {
            Console.WriteLine("Enter item name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter item price: ");
            double price = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter item quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            CartItem item = new CartItem {Name = name, Price = price, Quantity = quantity};
            service.AddItem(item);
            Console.WriteLine("Item added to cart.");
        }

        private static void ViewItemsInCart(ShoppingCartService service) 
        {
            var items = service.GetAll();
            if(items.Count == 0)
            {
                Console.WriteLine("Cart is currently empty.");
            }
            else 
            {
                Console.WriteLine("Items in cart: ");
                foreach(var item in items)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}