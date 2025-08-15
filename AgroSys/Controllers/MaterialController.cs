using AgroSys.Helpers;
using AgroSys.Managers;
using AgroSys.Models;
using AgroSys.UI;

namespace AgroSys.Controllers
{
    internal class MaterialController
    {
        public static void AddMaterialFlow()
        {
            MaterialUI.ShowTitle("Adicionar Material");

            var name = MaterialUI.ReadMaterialName();
            var amount = MaterialUI.ReadMaterialAmount();
            var value = MaterialUI.ReadMaterialValue();

            if (!CategoryController.TryGetCategory(out Category? category)) return;

            var newMaterial = new Material(name, amount, value, category!);

            if (MaterialManager.MaterialsCollection.Any(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase)))
            {
                MaterialUI.ShowMaterialExistsMsg();
                return;
            }

            MaterialManager.AddMaterial(newMaterial);

            MaterialUI.ShowMaterialAddedMsg();
        }
        public static void ShowMaterialList()
        {
            MaterialUI.ShowTitle("Lista de Materiais");

            var MaterialsColletion = MaterialManager.MaterialsCollection;

            if (!MaterialsColletion.Any())
            {
                MaterialUI.ShowNoMaterialMsg();
                return;
            }

            MaterialUI.ShowMaterialTable(MaterialsColletion);
            Console.ReadKey();
        }
        public static void SearchMaterialByName()
        {
            MaterialUI.ShowTitle("Procurando Produto");

            string MaterialName = Utils.ReadAndValidateInput<string>("\nInforme o nome do Material que deseja pesquisar: ");
            Console.WriteLine();
            var MaterialsCollection = MaterialManager.MaterialsCollection;

            var Material = MaterialsCollection.FirstOrDefault(c => c.Name.Equals(MaterialName, StringComparison.OrdinalIgnoreCase));

            if (Material == null)
            {
                MaterialUI.ShowMaterialNotFoundMsg();
                return;
            }

            MaterialUI.ShowMaterialTable(new[] { Material });
            Console.ReadKey();
        }
    }
}
