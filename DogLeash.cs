using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Inventory_MGMT_Console_App
{
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
