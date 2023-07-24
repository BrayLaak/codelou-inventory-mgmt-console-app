using CL_Inventory_MGMT_Console_App;
using System.Text.Json;

enum MainMenuOption
{
    AddProduct = 1,
    Exit
}

enum ProductType
{
    CatFood = 1,
    DogLeash
}

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Type 1 to add a product");
        Console.WriteLine("Type 2 to quit");
        MainMenuOption userInput = (MainMenuOption)int.Parse(Console.ReadLine());

        while (userInput != MainMenuOption.Exit)
        {
            if (userInput == MainMenuOption.AddProduct)
            {
                Console.WriteLine("Type 1 to add cat food. Type 2 to add dog leash");
                ProductType productType = (ProductType)int.Parse(Console.ReadLine());

                if (productType == ProductType.CatFood)
                {
                    CatFood catFood = new CatFood();

                    catFood.Name = PromptForString("Type the name of the product");
                    catFood.Price = PromptForDecimal("Type the price of the product");
                    catFood.Quantity = PromptForInt("Type the quantity of the product");
                    catFood.Description = PromptForString("Type the description of the product");
                    catFood.WeightPounds = PromptForDouble("Type the weight in pounds of the product");
                    catFood.KittenFood = PromptForBool("Is the product kitten food? Enter 'true' or 'false'");

                    Console.WriteLine(JsonSerializer.Serialize(catFood));
                    Console.WriteLine(catFood.KittenFood);
                }
                else if (productType == ProductType.DogLeash)
                {
                    DogLeash dogLeash = new DogLeash();

                    dogLeash.Name = PromptForString("Type the name of the product");
                    dogLeash.Price = PromptForDecimal("Type the price of the product");
                    dogLeash.Quantity = PromptForInt("Type the quantity of the product");
                    dogLeash.Description = PromptForString("Type the description of the product");
                    dogLeash.LengthInches = PromptForInt("Type the length in inches of the product", minValue: 1);
                    dogLeash.Material = PromptForString("Type the material of the product");

                    Console.WriteLine(JsonSerializer.Serialize(dogLeash));
                }
            }

            Console.WriteLine("Press 1 to add a product");
            Console.WriteLine("Press 2 to quit");
            userInput = (MainMenuOption)int.Parse(Console.ReadLine());
        }
    }

    private static string PromptForString(string prompt)
    {
        Console.WriteLine(prompt);
        return Console.ReadLine();
    }

    private static int PromptForInt(string prompt, int minValue = int.MinValue, int maxValue = int.MaxValue)
    {
        int value;
        do
        {
            Console.WriteLine(prompt);
            if (int.TryParse(Console.ReadLine(), out value) && value >= minValue && value <= maxValue)
            {
                break;
            }
            Console.WriteLine($"Invalid input. Please enter an integer between {minValue} and {maxValue}.");
        } while (true);
        return value;
    }

    private static double PromptForDouble(string prompt, double minValue = double.MinValue, double maxValue = double.MaxValue)
    {
        double value;
        do
        {
            Console.WriteLine(prompt);
            if (double.TryParse(Console.ReadLine(), out value) && value >= minValue && value <= maxValue)
            {
                break;
            }
            Console.WriteLine($"Invalid input. Please enter a number between {minValue} and {maxValue}.");
        } while (true);
        return value;
    }

    private static decimal PromptForDecimal(string prompt, decimal minValue = decimal.MinValue, decimal maxValue = decimal.MaxValue)
    {
        decimal value;
        do
        {
            Console.WriteLine(prompt);
            if (decimal.TryParse(Console.ReadLine(), out value) && value >= minValue && value <= maxValue)
            {
                break;
            }
            Console.WriteLine($"Invalid input. Please enter a number between {minValue} and {maxValue}.");
        } while (true);
        return value;
    }

    private static bool PromptForBool(string prompt)
    {
        bool value;
        do
        {
            Console.WriteLine(prompt);
            if (bool.TryParse(Console.ReadLine(), out value))
            {
                break;
            }
            Console.WriteLine("Invalid input. Please enter 'true' or 'false'.");
        } while (true);
        return value;
    }
}
