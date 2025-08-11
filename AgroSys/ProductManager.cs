using System.Collections.ObjectModel;

namespace AgroSys
{
    internal class ProductManager
    {
        private static readonly List<Product> _productList = new();
        public static ReadOnlyCollection<Product> ProductsCollection => _productList.AsReadOnly();
        
        public static void AddProduct(Product product)
        {
            _productList.Add(product);
        }
    }
}