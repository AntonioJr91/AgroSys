using AgroSys;

while (true)
{
    Console.Clear();
    Console.WriteLine("=== Agro Sys ===\n");
    Console.WriteLine("1. Gerenciar Produtos");
    Console.WriteLine("2. Gerenciar Categorias");
    Console.WriteLine("0. Encerrar programa");

    Console.Write("\nEscolha uma opção: ");
    string? option = Console.ReadLine();

    switch (option)
    {
        case "1":
            ProductUI.MenuProduct();
            break;
        case "2":
            CategoryUI.MenuCategory();
            break;
        case "3":
            break;
        case "0":
            Console.WriteLine("\nEncerrando programa...");
            return;
        default:
            Console.WriteLine("\nOpção inválida. Tente novamente.");
            break;
    }
    Console.Write("\nPressione qualquer tecla para continuar...");
    Console.ReadKey();
}