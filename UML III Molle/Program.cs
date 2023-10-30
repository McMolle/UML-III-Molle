using UML_III_Molle;

MenuCatalog menuCatalog = new MenuCatalog();

Console.WriteLine("Har oprettet menuCatalog...");
Console.WriteLine($"menuCatalog indeholder _{menuCatalog.Count}_ menuitems...");
Console.WriteLine("Tilføjer 1x pizza og 2x beverages...");

Pizza item1 = new Pizza(1, "Hawaii", "A delicious pizza with pineapple", 35, MenuType.Pizza, false, false, false);
Beverage item2 = new Beverage(2, "Pepsi", "-pepsi description-", 29.5, MenuType.Beverage, true, false, false);
Beverage item3 = new Beverage(3, "Moscow Mule", "-moscow mule description-", 45.5, MenuType.Beverage, true, true, true);

Console.WriteLine($"menuCatalog indeholder _{menuCatalog.Count}_ menuitems...");

try
{
    menuCatalog.Add(item1);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message );
}