using CL_Inventory_MGMT_Console_App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codelou_inventory_mgmt_console_app
{
    internal class ProductLogic
    {
        private List<Product> _products;
        private Dictionary<string, DogLeash> _dogLeashDict;
        private Dictionary<string, CatFood> _catFoodDict;

        public ProductLogic()
        {
            _products = new List<Product>();
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
    }
}
