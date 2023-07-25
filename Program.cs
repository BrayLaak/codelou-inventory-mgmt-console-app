﻿using CL_Inventory_MGMT_Console_App;
using codelou_inventory_mgmt_console_app;
using System.Text.Json;



internal class Program
{
    
    private static void Main(string[] args)
    {
        var productLogic = new ProductLogic();
        string userInput = MenuOptions();

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

                    productLogic.AddProduct(catFood);
                    Console.WriteLine("The product was added");

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

                    productLogic.AddProduct(dogLeash);
                    Console.WriteLine("The product was added");

                }

            }
            else if (userInput == "2")
            {
                Console.WriteLine("Type '1' to search a cat food. Type '2' to search a dog leash");
                userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    Console.WriteLine("Type the name of the product");
                    userInput = Console.ReadLine();
                    CatFood answer = productLogic.GetCatFoodByName(userInput);
                    answer.DisplayProperties();
                }
                else if (userInput == "2")
                {
                    Console.WriteLine("Type the name of the product");
                    userInput = Console.ReadLine();
                    var answer = productLogic.GetDogLeashByName(userInput);
                    answer.DisplayProperties();
                }


            }

            userInput = MenuOptions();
        }
    }

    private static string MenuOptions()
    {
        string userInput;
        Console.WriteLine("Press 1 to add a product");
        Console.WriteLine("Type '2' to search a product");
        Console.WriteLine("Type 'exit' to quit");
        userInput = Console.ReadLine();
        return userInput;
    }
}