using IMTest.BL.Models;
using System.Collections.Generic;

namespace IMTest.BL.Interfaces
{
    public interface IProductLogic
    {
        void AddProduct(Product product);
        DogLeash GetDogLeashByName(string name);
        CatFood GetCatFoodByName(string name);
        List<Product> GetAllProducts();
        decimal GetTotalPriceOfInventory();
        void PrintInStockProductNames();
    }
}
