using AgroSys.Controllers;
using AgroSys.Helpers;
using AgroSys.Models;

namespace AgroSys.UI
{
    internal class SectorUI
    {
        public static void ShowTitleProductHeader(string title)
        {
            Console.Clear();
            Console.WriteLine($"=== {title} ===\n");
        }

        public static void MenuSector()
        {
            MenuHelper.ShowMenu
                (
                    "Gerenciamento de Setor",
                    [
                        SectorController.AddSectorFlow,
                        SectorController.ShowSectorList,
                    ],
                    "Voltar ao menu inicial",
                    "Adicionar Setor", "Listar Setores"
                );
        }

        public static string ReadSectorName() => Utils.ReadAndValidateInput<string>("Nome do Setor: ");

        public static void ShowSectorTable(IEnumerable<Sector> sector)
        {
            Console.WriteLine($"{"Nome",-20}");

            foreach (var c in sector)
            {
                Console.WriteLine($"{c.Name,-20}");
            }

        }

        public static void ShowSectorAddedMsg()
        {
            Console.Write("\nSetor adicionado com sucesso!");
            Console.ReadKey();
        }

        public static void ShowSectorNotFound()
        {
            Console.Write("\nSetor não encontrado!");
            Console.ReadKey();
        }

        public static void ShowNoSectorMsg()
        {
            Console.Write("\nNenhum setor cadastrado.");
            Console.ReadKey();
        }
    }
}
