// See https://aka.ms/new-console-template for more information
using Composite;

Console.WriteLine("Hello, World!");


var menuComboHS = new MenuCombo("Hamburguer and Soda");
menuComboHS.AddComponent(new MenuItem("Hamburguer", 5.00M));
menuComboHS.AddComponent(new MenuItem("Soda", 2.00M));

var menuComboComplete = new MenuCombo("Master");
menuComboComplete.AddComponent(menuComboHS);
menuComboComplete.AddComponent(new MenuItem("Fries", 3.00M));

Console.WriteLine("------Combos-------");
menuComboHS.Display();
menuComboComplete.Display();

Console.ReadKey();