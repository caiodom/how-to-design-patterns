using FactoryMethod.Concrete;
using FactoryMethod.Creator;
using FactoryMethod.Utils;


Console.WriteLine("========= Gadget Store ======\n");
Console.WriteLine("Please specify the type of your gadget: (T)ablet, (C)ellphone or (L)aptop. ");
var chosenGadget = Console.ReadLine().ToUpper();
try
{

    GadgetType gadgetType = GadgetSelector.GetGadgetType(chosenGadget.ToUpper());

    Console.WriteLine("Please specify the brand of your gadget: (Apple), (Samsung) or (Xiaomi). ");
    var chosenbrandGadget = Console.ReadLine().ToUpper();

    GadgetBrand gadgetBrand= GadgetSelector.GetGadgetBrand(chosenbrandGadget.ToUpper());


    GadgetFactoryMethod myGadgetType = GadgetSimpleFactory.CreateGadget(gadgetType);

    var myGadget = myGadgetType.ChooseTheBrand(gadgetBrand);


    myGadget.Packaging();
    myGadget.Delivering();
    Console.WriteLine($"Enjoy your gadget!!.");
}
catch (Exception ex)
{
    Console.WriteLine("Error :" + ex.Message);
}
Console.ReadLine();
