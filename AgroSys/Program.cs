using AgroSys;

string[] options = { "Gerenciar Produtos", "Gerenciar Categorias" };
Action[] actions = { ProductUI.MenuProduct, CategoryUI.CategoryMenu };

MenuHelper.ShowMenu("Agro Sys", actions, "Encerrar o programa", options);