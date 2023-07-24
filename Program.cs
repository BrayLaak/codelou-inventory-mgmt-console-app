using CL_Inventory_MGMT_Console_App;
using System.Text.Json;

internal class Program
{
    
    private static void Main(string[] args)
    {
        Console.WriteLine("Type 1 to add a product");
        Console.WriteLine("Type 'exit' to quit");
        string userInput = Console.ReadLine();

        while (userInput.ToLower() != "exit")
        {
            if (userInput == "1")
            {
                Console.WriteLine("Type 1 to add cat food. Press 2 to add dog leash");
                userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    CatFood catFood = new CatFood();

                    Console.WriteLine("Type the name of the product");
                    catFood.Name = Console.ReadLine();

                    Console.WriteLine("Type the price of the product");
                    catFood.Price = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Type the quantity of the product");
                    catFood.Quantity = int.Parse(Console.ReadLine());

                    Console.WriteLine("Type the description of the product");
                    catFood.Description = Console.ReadLine();

                    Console.WriteLine("Type the weight in pounds of the product");
                    catFood.WeightPounds = double.Parse(Console.ReadLine());

                    Console.WriteLine("Is the product kitten food? Enter 'true' or 'false'");
                    catFood.KittenFood = bool.Parse(Console.ReadLine());

                    Console.WriteLine(JsonSerializer.Serialize(catFood));
                    Console.WriteLine(catFood.KittenFood);

                }

                else if (userInput == "2")
                {
                    DogLeash dogLeash = new DogLeash();

                    Console.WriteLine("Type the name of the product");
                    dogLeash.Name = Console.ReadLine();

                    Console.WriteLine("Type the price of the product");
                    dogLeash.Price = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Type the quantity of the product");
                    dogLeash.Quantity = int.Parse(Console.ReadLine());

                    Console.WriteLine("Type the description of the product");
                    dogLeash.Description = Console.ReadLine();

                    Console.WriteLine("Type the length in inches of the product");
                    dogLeash.LengthInches = int.Parse(Console.ReadLine());

                    Console.WriteLine("Type the material of the product");
                    dogLeash.Material = Console.ReadLine();

                    Console.WriteLine(JsonSerializer.Serialize(dogLeash));
                }

            }

            Console.WriteLine("Press 1 to add a product");
            Console.WriteLine("Type 'exit' to quit");
            userInput = Console.ReadLine();
        }
    }
}