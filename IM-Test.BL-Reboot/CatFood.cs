using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMTest.BL
{
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
