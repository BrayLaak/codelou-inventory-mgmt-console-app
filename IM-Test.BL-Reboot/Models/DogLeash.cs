using System;

namespace IMTest.BL.Models
{
    /// <summary>
    /// Represents a dog leash product.
    /// </summary>
    public class DogLeash : Product
    {
        public int LengthInches { get; set; }
        public string Material { get; set; }

        public override void DisplayProperties()
        {
            base.DisplayProperties();
            Console.WriteLine($"LengthInches: {LengthInches}");
            Console.WriteLine($"Material: {Material}");
        }
    }
}
