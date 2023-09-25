using System;
using IMTest.BL;

namespace IMTest.UI
{
    internal class UserInterface
    {
        private readonly ProductLogic _productLogic;

        public UserInterface(ProductLogic productLogic)
        {
            _productLogic = productLogic;
        }

        public void Run()
        {
            string userInput;

            do
            {
                DisplayMainMenu();
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        AddProduct();
                        break;
                    case "2":
                        SearchProduct();
                        break;
                    case "3":
                        DisplayInStockProductNames();
                        break;
                    case "4":
                        CalculateTotalPrice();
                        break;
                    case "exit":
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }

            } while (userInput.ToLower() != "exit");
        }

        private void DisplayMainMenu()
        {
            Console.WriteLine("\nMain Menu:");
            Console.WriteLine("1. Add a product");
            Console.WriteLine("2. Search a product");
            Console.WriteLine("3. Display names of in-stock products");
            Console.WriteLine("4. Calculate total price of inventory");
            Console.WriteLine("Type 'exit' to quit.\n");
        }

        private void AddProduct()
        {
            Console.WriteLine("Type '1' to add Cat Food or '2' to add Dog Leash:");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                // Add CatFood logic
                Console.WriteLine("Enter the name of the Cat Food:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the price of the Cat Food:");
                if (!decimal.TryParse(Console.ReadLine(), out decimal price))
                {
                    Console.WriteLine("Invalid price input.");
                    return;
                }
                Console.WriteLine("Enter the quantity of the Cat Food:");
                if (!int.TryParse(Console.ReadLine(), out int quantity))
                {
                    Console.WriteLine("Invalid quantity input.");
                    return;
                }
                Console.WriteLine("Enter the description of the Cat Food:");
                string description = Console.ReadLine();
                Console.WriteLine("Enter the weight in pounds of the Cat Food:");
                if (!double.TryParse(Console.ReadLine(), out double weightPounds))
                {
                    Console.WriteLine("Invalid weight input.");
                    return;
                }
                Console.WriteLine("Is the Cat Food for kittens? (true/false):");
                if (!bool.TryParse(Console.ReadLine(), out bool isKittenFood))
                {
                    Console.WriteLine("Invalid input for kitten food.");
                    return;
                }

                CatFood catFood = new CatFood
                {
                    Name = name,
                    Price = price,
                    Quantity = quantity,
                    Description = description,
                    WeightPounds = weightPounds,
                    KittenFood = isKittenFood
                };

                _productLogic.AddProduct(catFood);
                Console.WriteLine("The Cat Food was added successfully.");
            }
            else if (userInput == "2")
            {
                // Add DogLeash logic
                Console.WriteLine("Enter the name of the Dog Leash:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the price of the Dog Leash:");
                if (!decimal.TryParse(Console.ReadLine(), out decimal price))
                {
                    Console.WriteLine("Invalid price input.");
                    return;
                }
                Console.WriteLine("Enter the quantity of the Dog Leash:");
                if (!int.TryParse(Console.ReadLine(), out int quantity))
                {
                    Console.WriteLine("Invalid quantity input.");
                    return;
                }
                Console.WriteLine("Enter the description of the Dog Leash:");
                string description = Console.ReadLine();
                Console.WriteLine("Enter the length in inches of the Dog Leash:");
                if (!int.TryParse(Console.ReadLine(), out int lengthInches))
                {
                    Console.WriteLine("Invalid length input.");
                    return;
                }
                Console.WriteLine("Enter the material of the Dog Leash:");
                string material = Console.ReadLine();

                DogLeash dogLeash = new DogLeash
                {
                    Name = name,
                    Price = price,
                    Quantity = quantity,
                    Description = description,
                    LengthInches = lengthInches,
                    Material = material
                };

                _productLogic.AddProduct(dogLeash);
                Console.WriteLine("The Dog Leash was added successfully.");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }

        private void SearchProduct()
        {
            Console.WriteLine("Type '1' to search for Cat Food or '2' to search for Dog Leash:");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Console.WriteLine("Enter the name of the Cat Food:");
                string name = Console.ReadLine();
                CatFood catFood = _productLogic.GetCatFoodByName(name);
                if (catFood != null)
                {
                    catFood.DisplayProperties();
                }
                else
                {
                    Console.WriteLine("Cat Food not found.");
                }
            }
            else if (userInput == "2")
            {
                Console.WriteLine("Enter the name of the Dog Leash:");
                string name = Console.ReadLine();
                DogLeash dogLeash = _productLogic.GetDogLeashByName(name);
                if (dogLeash != null)
                {
                    dogLeash.DisplayProperties();
                }
                else
                {
                    Console.WriteLine("Dog Leash not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }

        private void DisplayInStockProductNames()
        {
            _productLogic.PrintInStockProductNames();
        }

        private void CalculateTotalPrice()
        {
            decimal totalPrice = _productLogic.GetTotalPriceOfInventory();
            Console.WriteLine($"Total Price of Inventory: ${totalPrice}");
        }
    }
}