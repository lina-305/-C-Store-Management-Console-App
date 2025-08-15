using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject
{
    public class Product
    {
        string Name;
        int Quantity;
        double Price;
        public string name { get { return Name; } set { Name = value; } }
        public int quantity { get { return Quantity; } set { Quantity = value; } }
        public double price { get { return Price; } set { Price = value; } }
        public Product(string Name, int Quantity , double Price)
        {
            this.Name = Name;
            this.Quantity = Quantity;
            this.Price = Price;

          
            
        }
        public Product()
        {
           
            
        }
       
        public void show_details()
        {
                Console.WriteLine("The product deatils:");
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Quantity: {Quantity}");
                Console.WriteLine($"Price: {Price}");
        }



    }
}
