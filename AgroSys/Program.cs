using AgroSys.Helpers;
using AgroSys.UI;

string[] options = { "Produtos", "Categorias", "Setor" };
Action[] actions = { MaterialUI.MenuProduct, CategoryUI.CategoryMenu, SectorUI.MenuSector };

MenuHelper.ShowMenu("Agro Sys", actions, "Encerrar o programa", options);