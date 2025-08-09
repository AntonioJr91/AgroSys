namespace AgroSys
{
    internal class ProductUI
    {
        public static void MenuProduct()
        {
            MenuHelper.ShowMenu(
                        "Gerenciamento de Produtos",
                        [HandleAddProduct, DisplayList, SearchForProductByName],
                        "Voltar ao menu inicial",
                        "Adicionar Produto", "Listar Produtos", "Pesquisar Produto"
            );
        }
        public static void HandleAddProduct()
        {
            Console.Clear();
            Console.WriteLine("=== Adicionando um novo produto ===\n");

            string name = Utils.ReadAndValidateInput<string>("Insira o nome: ");
            int amount = Utils.ReadAndValidateInput<int>("Insira a quantidade: ");
            decimal value = Utils.ReadAndValidateInput<decimal>("Insira o valor: R$");

            if (!TryGetCategory(out Category? category)) return;

            Product newProduct = new(name, amount, value, category!);

            ProductManager.AddProduct(newProduct);
        }
        private static bool TryGetCategory(out Category? category)
        {
            string name = Utils.ReadAndValidateInput<string>("Insira a categoria: ");

            category = ProductManager.CategoriesCollection
                .FirstOrDefault(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (category == null)
            {
                Console.WriteLine("\nCategoria inexistente! Verifique os dados e tente novamente.");
                Console.ReadKey();
                return false;
            }

            return true;
        }
        public static void DisplayList()
        {
            Console.Clear();
            Console.WriteLine("=== Listagem de produtos ===\n");

            var ProductsColletion = ProductManager.ProductsCollection;

            if (!ProductsColletion.Any())
            {
                Console.WriteLine("Nenhum produto cadastrado.");
                return;
            }

            Console.WriteLine($"{"Id",-5} {"Nome",-20} {"Quantidade",-10} {"Valor",-10} {"Categoria",-15} {"Data de criação",-15}");
            foreach (var p in ProductsColletion)
            {
                Console.WriteLine($"{p.Id,-5} {p.Name,-20} {p.Amount,-10} {p.Value,-10:C} {p.Category.Name,-15} {p.Created_At,-15}");
            }
        }
        public static void SearchForProductByName()
        {
            Console.Clear();
            Console.WriteLine("=== Procurando um produto ===\n");

            string productName = Utils.ReadAndValidateInput<string>("Informe o nome do produto que deseja pesquisar: ");
            var productsCollection = ProductManager.ProductsCollection;

            var product = productsCollection.FirstOrDefault(c => c.Name.Equals(productName, StringComparison.OrdinalIgnoreCase));
            if (product == null)
            {
                Console.WriteLine("Produto não encontrado!");
                return;
            }
            Console.WriteLine($"\n{"Id",-5} {"Nome",-20} {"Quantidade",-10} {"Valor",-10} {"Categoria",-15} {"Data de criação",-15}");
            Console.WriteLine($"{product.Id,-5} {product.Name,-20} {product.Amount,-10} {product.Value,-10:C} {product.Category.Name,-15} {product.Created_At,-15}");
        }
    }
}