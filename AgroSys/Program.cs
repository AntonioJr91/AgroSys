using AgroSys.Helpers;
using AgroSys.UI;

string[] options = { "Produtos", "Categorias", "Setor", "Ordem de Serviço" };
Action[] actions = { MaterialUI.Menu, CategoryUI.Menu, SectorUI.Menu };

MenuHelper.ShowMenu("Agro Sys", actions, "Encerrar o programa", options);
