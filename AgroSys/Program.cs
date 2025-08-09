using AgroSys;

string[] options = { "Gerenciar Produtos", "Gerenciar Categorias" };
Action[] actions = { ProductUI.MenuProduct };

MenuHelper.ShowMenu("Agro Sys", actions, "Encerrar o programa", options);