using AgroSys;

while (true)
{
    Console.Clear();
    Console.WriteLine("=== Agro Sys ===\n");
    Console.WriteLine("1 - Gerenciar Produtos");
    Console.WriteLine("0 - Sair");

    Console.Write("\nEscolha uma opção: ");
    string? option = Console.ReadLine();

    switch (option)
    {
        case "1":
            ProductManager.AddProduct();
            break;
        case "2":
            break;
        case "3":
            break;
        case "0":
            Console.WriteLine("\nSaindo...");
            return;
        default:
            Console.WriteLine("\nOpção inválida. Tente novamente.");
            break;
    }
    Console.WriteLine("\nPressione qualquer tecla para continuar...");
    Console.ReadKey();
}