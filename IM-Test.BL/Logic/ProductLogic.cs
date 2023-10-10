using System;
using System.Collections.Generic;
using System.Linq;
using IMTest.BL.Interfaces;
using IMTest.BL.Models;
using IMTest.BL.Extensions;

namespace IMTest.BL.Logic
{
    public class ProductLogic : IProductLogic
    {
        private List<Product> _products;
        private Dictionary<string, DogLeash> _dogLeashDict;
        private Dictionary<string, CatFood> _catFoodDict;

        public ProductLogic()
        {
            InitializeTestData();
        }

        // Initialize test data for demonstration
        private void InitializeTestData()
        {
            _products = new List<Product>
            {
                new Product { Description = "test", Name = "test", Price = 1, Quantity = 1 },
                new Product { Description = "test2", Name = "test2", Price = 2, Quantity = 2 },
                new Product { Description = "test3", Name = "test3", Price = 3, Quantity = 0 }
            };

            _dogLeashDict = new Dictionary<string, DogLeash>();
            _catFoodDict = new Dictionary<string, CatFood>();
        }

        // Implement interface methods...

        public void AddProduct(Product product)
        {
            if (product is DogLeash)
                _dogLeashDict.Add(product.Name, product as DogLeash);
            else if (product is CatFood)
                _catFoodDict.Add(product.Name, product as CatFood);

            _products.Add(product);
        }

        public DogLeash GetDogLeashByName(string name)
        {
            try
            {
                return _dogLeashDict[name];
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public CatFood GetCatFoodByName(string name)
        {
            if (_catFoodDict.TryGetValue(name, out CatFood value))
            {
                return _catFoodDict[name];
            }
            else
            {
                Console.WriteLine("The product was not found.");
                return null;
            }
        }

        public List<Product> GetAllProducts()
        {
            return _products;
        }

        public decimal GetTotalPriceOfInventory()
        {
            // Calculate the total price of in-stock products
            decimal totalPrice = _products.InStock().Sum(x => x.Price);
            return totalPrice;
        }

        public void PrintInStockProductNames()
        {
            Console.WriteLine("\nProducts in Stock:");
            var inStockProducts = _products.InStock();
            foreach (Product item in inStockProducts)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine();
        }
    }
}
