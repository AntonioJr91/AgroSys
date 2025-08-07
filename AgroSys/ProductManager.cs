using System.Collections.ObjectModel;

namespace AgroSys
{
    internal class ProductManager
    {
        private static readonly List<Product> _ProductList = new();
        private static List<Category> _CategoriesList = new();
        public static ReadOnlyCollection<Product> ProductsCollection => _ProductList.AsReadOnly();
        public static ReadOnlyCollection<Category> CategoriesCollection => _CategoriesList.AsReadOnly();

        public static void AddProduct(Product produto)
        {
            _ProductList.Add(produto);
            Console.WriteLine("Produto adicionado com sucesso!");
        }

        public static void AddCategory(Category category)
        {
            _CategoriesList.Add(category);
            Console.WriteLine("Categoria adicionada com sucesso!");
        }
    }
}