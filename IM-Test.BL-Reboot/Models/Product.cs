using System;

namespace IMTest.BL.Models
{
    /// <summary>
    /// Represents a generic product.
    /// </summary>
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }

        public virtual void DisplayProperties()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Quantity: {Quantity}");
            Console.WriteLine($"Description: {Description}");
        }
    }
}
