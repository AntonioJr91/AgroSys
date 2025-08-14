using AgroSys.Models;
using System.Collections.ObjectModel;

namespace AgroSys.Managers
{
    internal class MaterialManager
    {
        private static readonly List<Material> _productList = new();
        public static ReadOnlyCollection<Material> ProductsCollection => _productList.AsReadOnly();
        
        public static void AddProduct(Material product)
        {
            _productList.Add(product);
        }
    }
}