using AgroSys.Helpers;
using AgroSys.UI;

string[] options = { "Produtos", "Categorias", "Ordem de Serviço", "Gerenciamento do Sistema" };
Action[] actions = { MaterialUI.MenuProduct, CategoryUI.CategoryMenu };

MenuHelper.ShowMenu("Agro Sys", actions, "Encerrar o programa", options);