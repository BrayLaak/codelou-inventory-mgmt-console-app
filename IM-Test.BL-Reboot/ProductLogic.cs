using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMTest.BL
{
 /// <summary>
 /// 
 /// </summary>
    public class ProductLogic : IProductLogic
    {
        private List<Product> _products;
        private Dictionary<string, DogLeash> _dogLeashDict;
        private Dictionary<string, CatFood> _catFoodDict;

        public ProductLogic()
        {
            _products = new List<Product>();

            _products.Add(new Product()
            {
                Description = "test",
                Name = "test",
                Price = 1,
                Quantity = 1,
            });

            _products.Add(new Product()
            {
                Description = "test2",
                Name = "test2",
                Price = 2,
                Quantity = 2,
            });

            _products.Add(new Product()
            {
                Description = "test3",
                Name = "test3",
                Price = 3,
                Quantity = 0,
            });
        

        _dogLeashDict = new Dictionary<string, DogLeash>();
            _catFoodDict = new Dictionary<string, CatFood>();
        }
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

            /*
            if (_dogLeashDict.TryGetValue(name, out DogLeash value))
            {
                return _dogLeashDict[name];
            }
            
            else
            {
                Console.WriteLine("The product was not found.");
                return null;
            }
            */
            
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
            decimal totalPrice = _products.Sum(product => product.Price * product.Quantity);
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

            Console.WriteLine("");
        }

    }
}
