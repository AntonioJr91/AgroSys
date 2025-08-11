using System.Collections.ObjectModel;

namespace AgroSys
{
    internal class CategoryManager
    {
        private static readonly List<Category> _categoriesList = new();
        public static ReadOnlyCollection<Category> CategoriesCollection => _categoriesList.AsReadOnly();

        public static void AddCategory(Category category)
        {
            _categoriesList.Add(category);
        }
    }
}
