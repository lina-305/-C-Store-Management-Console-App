using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Myproject
{
    public class Store 
    {
        public static List<Product> products = new List<Product>();
        public static void Show_store()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("No items yet, please add some!");
            }
            foreach (var item in products)
            {
                item.show_details();
                Console.WriteLine("\n================\n");
            }
            Console.ReadKey();
            Console.Clear();
        }

        public static void Add_item()
        {
            //name
            Product p = new Product();
            Console.Write("Enter the name of the new item:");
            string name = Console.ReadLine();
            p.name = name;
            Console.Clear();

            //quantity
            Console.Write("Enter the quantity ot the new item:");
            int quantity =int.Parse( Console.ReadLine());
            if (quantity <= 0)
            {
                while (quantity <= 0)
                {
                    Console.WriteLine("You can't enter a quantity less the 0!");
                    Console.Write("Enter another quantity:");
                    quantity = int.Parse(Console.ReadLine());
                }
                p.quantity = quantity;
            }
            else
            {
                p.quantity = quantity;

            }
            Console.Clear();

            //price
            Console.Write("Enter the price ot the new item:");
            double price = double.Parse(Console.ReadLine());
            if (price <= 0)
            {
                while (price <= 0)
                {
                    Console.WriteLine("You can't enter a price less the 0!");
                    Console.Write("Enter another price:");
                    price = double.Parse(Console.ReadLine());
                }
                p.price = price;
            }
            else
            {
                p.price = price;
            }
            Console.Clear();
            products.Add(p);
        }

        public static void Buy_item()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("No items yet, please add some!");
            }
            else
            {
                //index
                Console.Write("Please enter the number of the item you want to buy:");
                Console.WriteLine();
                for (int i = 0; i < products.Count; i++)
                {
                    Console.WriteLine($"{i + 1}-{products[i].name}");
                }
                int num = (int.Parse(Console.ReadLine())) - 1;
                if (num >= products.Count || num < 0)
                {
                    while (num >= products.Count || num < 0)
                    {
                        Console.Write("Wrong number! try again:");
                         num = (int.Parse(Console.ReadLine())) - 1;
                    }
                }
                Console.Clear();

                //quantity
                Console.Write("Please enter the quantity:");
                int q_customar = int.Parse(Console.ReadLine());
                if (q_customar < 0)
                {
                    while (q_customar < 0)
                    {
                        Console.WriteLine("You can't enter a quantity less the 0!");
                        Console.Write("Enter another quantity:");
                        q_customar = int.Parse(Console.ReadLine());
                    }
                    
                }
               
                if (q_customar > products[num].quantity)
                {
                    Console.WriteLine("Sorry, The quantity isn't enough!");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    products[num].quantity -= q_customar;
                    Console.Clear();
                    Console.WriteLine("Done!");
                    Console.WriteLine("Thanks for buying.");
                    Console.ReadKey();
                    Console.Clear();
                    if (products[num].quantity == 0)
                    {
                        products.RemoveAt(num);
                    }
                }
            }
        }
        public static void Search_item()
        
        {
            if (products.Count == 0)
            {
                Console.WriteLine("No items yet, please add some!");
            }
            else
            {
                Console.Write("Please enter the name of the item you want to search:");
                string item = (Console.ReadLine().ToLower());
                bool Is_Found = false;
                    for (int i = 0; i < products.Count; i++)
                    {
                        if (products[i].name.ToLower() == item)
                        {
                            products[i].show_details();
                            Console.ReadKey();
                            Console.Clear();
                            Is_Found = true;
                            break;
                        }
                    }
                
               if(!Is_Found)
                {
                    Console.WriteLine("Not found!");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
        
    }
}
