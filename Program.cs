using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Myproject
{

    internal class Program
    {
        static void Main(string[] args)
        {
            if (File.Exists("products.json"))
            {
                Store.products = JsonConvert.DeserializeObject<List<Product>>(File.ReadAllText("products.json"));
            }

            Console.WriteLine("Welcome to my store");
            string choice = "";
            while (choice != "e")
            { 
                Console.WriteLine("please select the choice you want");
                Console.WriteLine();
                Console.WriteLine("========");
                Console.WriteLine();
                Console.WriteLine("(1) Add item");
                Console.WriteLine("(2) Show the store items");
                Console.WriteLine("(3) Buy an item");
                Console.WriteLine("(4) Search for an item");
                Console.WriteLine("Finally 'e' for exit the store");
                Console.Write("Your choice:");
                choice = Console.ReadLine();
                Console.Clear();
                switch (choice)
                {
                    case "1":
                        Store.Add_item();
                        break;
                    case "2":
                        Store.Show_store();
                        break;
                    case "3":
                        Store.Buy_item();
                        break;
                    case "4":
                        Store.Search_item();
                        break;
                    case "e":
                        Console.WriteLine("Thanks for your visit, See you next time");
                        File.WriteAllText("products.json", JsonConvert.SerializeObject(Store.products));
                        break;
                    default:
                        Console.WriteLine("Please enter a valid option");
                        break;
                }
            }
        }
    }
}
