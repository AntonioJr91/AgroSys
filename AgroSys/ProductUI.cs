namespace AgroSys
{
    internal class ProductUI
    {
        public static void MenuProduct()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Gerenciamento de produtos ===\n");
                Console.WriteLine("1. Adicionar produto");
                Console.WriteLine("2. Listar produtos cadastrados");
                Console.WriteLine("3. Pesquisar por produto");
                Console.WriteLine("0. Voltar ao menu principal");
                Console.Write("\nEscolha uma opção: ");
                string? option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        HandleAddProduct();
                        break;
                    case "2":
                        DisplayList();
                        break;
                    case "3":
                        SearchForProductByName();
                        break;
                    case "0":
                        Console.WriteLine("\nSaindo do gerenciador de produtos...");
                        return;
                    default:
                        Console.WriteLine("\nOpção inválida. Tente novamente.");
                        break;
                }

                Console.Write("\nPressione qualquer tecla para retornar...");
                Console.ReadKey();
            }
        }
        public static void HandleAddProduct()
        {
            Console.Clear();
            Console.WriteLine("=== Adicionando um novo produto ===\n");

            string name = Utils.ReadAndValidateInput<string>("Insira o nome: ");
            int amount = Utils.ReadAndValidateInput<int>("Insira a quantidade: ");
            decimal value = Utils.ReadAndValidateInput<decimal>("Insira o valor: R$");

            Category category = ValidateCategoryName();

            Product newProduct = new(name, amount, value, category);

            ProductManager.AddProduct(newProduct);
        }
        private static Category ValidateCategoryName()
        {
            string name = Utils.ReadAndValidateInput<string>("Insira a categoria: ");
            var category = ProductManager.CategoriesCollection
                .FirstOrDefault(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (category == null)
            {
                Console.WriteLine("\nCategoria inexistente! Verifique os dados e tente novamente.");
                return null!;
            }

            return category;
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

            var product = productsCollection.FirstOrDefault(c => c.Name.Equals(productName,StringComparison.OrdinalIgnoreCase));
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