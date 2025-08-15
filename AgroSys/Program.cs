using AgroSys.Helpers;
using AgroSys.UI;

string[] options = { "Produtos", "Categorias", "Setor", "Ordem de Serviço" };
Action[] actions = { MaterialUI.MenuMaterial, CategoryUI.CategoryMenu, SectorUI.MenuSector };

MenuHelper.ShowMenu("Agro Sys", actions, "Encerrar o programa", options);
