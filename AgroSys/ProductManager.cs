using System.Collections.ObjectModel;

namespace AgroSys
{
    internal class ProductManager
    {
        private static readonly List<Product> _ProductList = new();
        private static List<Category> _CategoriesList = new();
        public static ReadOnlyCollection<Product> ProductsColletion => _ProductList.AsReadOnly();
        public static ReadOnlyCollection<Category> CategoriesColletion => _CategoriesList.AsReadOnly();
        public static void AddProduct()
        {
            string name = Utils.ReadAndValidateInput<string>("Insira o nome: ");
            int amount = Utils.ReadAndValidateInput<int>("Insira a quantidade: ");
            decimal value = Utils.ReadAndValidateInput<decimal>("Insira o valor: R$");
            string categoryName = Utils.ReadAndValidateInput<string>("Insira a categoria: ");
        }
        public static void DisplayProductList()
        {
            foreach (var p in ProductsColletion)
            {
                Console.WriteLine($"{"Id",-5} {"Nome",-20} {"Quantidade",-10} {"Valor",-10} {"Categoria",-15} {"Data de criação",-15}");
                Console.WriteLine($"{p.Id,-5} {p.Name,-20} {p.Amount,-10} {p.Value,-10:C} {p.Category.Name,-15} {p.Created_At,-15}");
            }
        }
        public static void DisplayCategoriesList()
        {
            Console.WriteLine($"{"Id",-5} {"Nome",-20}");
            foreach (var c in CategoriesColletion)
                Console.WriteLine($"{c.Id,-5} {c.Name,-20}");
        }
    }
}