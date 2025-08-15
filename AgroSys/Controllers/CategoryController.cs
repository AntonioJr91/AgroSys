using AgroSys.Helpers;
using AgroSys.Managers;
using AgroSys.Models;
using AgroSys.UI;

namespace AgroSys.Controllers
{
    internal class CategoryController
    {
        public static void AddCategoryFlow()
        {
            CategoryUI.ShowTitle("Adicionar Categoria");

            var categoryName = CategoryUI.ReadCategoryName();

            if (CategoryManager.CategoriesCollection.Any(c => c.Name.Equals(categoryName, StringComparison.OrdinalIgnoreCase)))
            {
                CategoryUI.ShowCategoryExistsMsg();
                return;
            }

            Category category = new(categoryName);

            CategoryManager.AddCategory(category);

            CategoryUI.ShowCategoryAddedMsg();
        }
        public static void ShowCategoryList()
        {
            CategoryUI.ShowTitle("Lista de Categoria");

            var categoriesCollection = CategoryManager.CategoriesCollection;

            if (!categoriesCollection.Any())
            {
                CategoryUI.ShowNoCategoryMsg();
                return;
            }

            CategoryUI.ShowCategoryTable(categoriesCollection);
            Console.ReadKey();
        }
        public static bool TryGetCategory(out Category? category)
        {
            string name = Utils.ReadAndValidateInput<string>("Insira a categoria: ");

            category = CategoryManager.CategoriesCollection
                .FirstOrDefault(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (category == null)
            {
                CategoryUI.ShowCategoryNotFoundMsg();
                return false;
            }

            return true;
        }
    }
}
