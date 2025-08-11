namespace AgroSys
{
    internal class ProductController
    {
        public static void AddProductFlow()
        {
            ProductUI.ShowTitleProductHeader("Adicionar Produto");

            var name = ProductUI.ReadProductName();
            var amount = ProductUI.ReadProductAmount();
            var value = ProductUI.ReadProductValue();

            if (!CategoryController.TryGetCategory(out Category? category)) return;

            var newProduct = new Product(name, amount, value, category!);

            if (ProductManager.ProductsCollection.Any(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase)))
            {
                ProductUI.ShowProductExistsMsg();
                return;
            }

            ProductManager.AddProduct(newProduct);

            ProductUI.ShowProductAddedMsg();
        }
        public static void ShowProductList()
        {
            ProductUI.ShowTitleProductHeader("Lista de Produtos");

            var productsColletion = ProductManager.ProductsCollection;

            if (!productsColletion.Any())
            {
                ProductUI.ShowNoProductMsg();
                return;
            }

            ProductUI.ShowProductTable(productsColletion);
            Console.ReadKey();
        }
        public static void SearchProductByName()
        {
            ProductUI.ShowTitleProductHeader("Procurando Produto");

            string productName = Utils.ReadAndValidateInput<string>("Informe o nome do produto que deseja pesquisar: \n");
            var productsCollection = ProductManager.ProductsCollection;

            var product = productsCollection.FirstOrDefault(c => c.Name.Equals(productName, StringComparison.OrdinalIgnoreCase));

            if (product == null)
            {
                ProductUI.ShowProductNotFound();
                return;
            }

            ProductUI.ShowProductTable(new[] { product });
            Console.ReadKey();
        }
    }
}
