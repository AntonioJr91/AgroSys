using AgroSys.Helpers;
using AgroSys.Managers;
using AgroSys.Models;
using AgroSys.UI;

namespace AgroSys.Controllers
{
    internal class MaterialController
    {
        public static void AddProductFlow()
        {
            MaterialUI.ShowTitleProductHeader("Adicionar Produto");

            var name = MaterialUI.ReadProductName();
            var amount = MaterialUI.ReadProductAmount();
            var value = MaterialUI.ReadProductValue();

            if (!CategoryController.TryGetCategory(out Category? category)) return;

            var newProduct = new Material(name, amount, value, category!);

            if (MaterialManager.ProductsCollection.Any(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase)))
            {
                MaterialUI.ShowProductExistsMsg();
                return;
            }

            MaterialManager.AddProduct(newProduct);

            MaterialUI.ShowProductAddedMsg();
        }
        public static void ShowProductList()
        {
            MaterialUI.ShowTitleProductHeader("Lista de Produtos");

            var productsColletion = MaterialManager.ProductsCollection;

            if (!productsColletion.Any())
            {
                MaterialUI.ShowNoProductMsg();
                return;
            }

            MaterialUI.ShowProductTable(productsColletion);
            Console.ReadKey();
        }
        public static void SearchProductByName()
        {
            MaterialUI.ShowTitleProductHeader("Procurando Produto");

            string productName = Utils.ReadAndValidateInput<string>("\nInforme o nome do produto que deseja pesquisar: ");
            Console.WriteLine();
            var productsCollection = MaterialManager.ProductsCollection;

            var product = productsCollection.FirstOrDefault(c => c.Name.Equals(productName, StringComparison.OrdinalIgnoreCase));

            if (product == null)
            {
                MaterialUI.ShowProductNotFound();
                return;
            }

            MaterialUI.ShowProductTable(new[] { product });
            Console.ReadKey();
        }
    }
}
