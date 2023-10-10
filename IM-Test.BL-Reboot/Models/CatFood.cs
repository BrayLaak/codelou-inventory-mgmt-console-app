using System;

namespace IMTest.BL.Models
{
    /// <summary>
    /// Represents a cat food product.
    /// </summary>
    public class CatFood : Product
    {
        public double WeightPounds { get; set; }
        public bool KittenFood { get; set; }

        public override void DisplayProperties()
        {
            base.DisplayProperties();
            Console.WriteLine($"WeightPounds: {WeightPounds}");
            Console.WriteLine($"KittenFood: {KittenFood}");
        }
    }
}
