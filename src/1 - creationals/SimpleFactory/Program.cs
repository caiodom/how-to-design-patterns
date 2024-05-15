// See https://aka.ms/new-console-template for more information
using SimpleFactory;
using SimpleFactory.Utils;

Console.WriteLine("========= Gadget Store ======\n");
Console.WriteLine("Please specify the type of your gadget: (T)ablet, (C)ellphone, or (L)aptop. ");
var chosenGadget = Console.ReadLine().ToUpper();
try
{

     GadgetType gadgetType=GadgetTypeSelector.GetGadgetType(chosenGadget.ToUpper());
     Gadget gadget= GadgetSimpleFactory.Create(gadgetType);
     gadget.Packaging();
     gadget.Delivering();
     Console.WriteLine($"Enjoy your {gadget.Name}!!.");
}
catch(Exception ex)
{
    Console.WriteLine("Error :" + ex.Message);
}
Console.ReadLine();

