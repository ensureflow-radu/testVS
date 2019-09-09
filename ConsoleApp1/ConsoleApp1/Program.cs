using ClassLibrary.DataAccess;
using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My test with plural sight");
            var dataProvider = new CoffeeShopDataProvider();
            while(true)
            {
                var line = Console.ReadLine();
                var coffeeShops = dataProvider.LoadCoffessShops();
                if (string.Equals("help", line, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("> Available coffee shop commands:");
                    foreach (var coffeeShop in coffeeShops)
                    {
                        Console.WriteLine($"> " + coffeeShop.Location);
                    }
                }
                else
                {
                    var foundCoffeeShops = coffeeShops.Where(t => t.Location.StartsWith(line, StringComparison.OrdinalIgnoreCase)).ToList();
                    if (foundCoffeeShops.Count == 0)
                    {
                        Console.WriteLine($"> Command '{line}' not found.");
                    }
                    else if (foundCoffeeShops.Count == 1)
                    {
                        var coffeeShop = foundCoffeeShops.Single();
                        Console.WriteLine($">Location: {coffeeShop.Location}");
                        Console.WriteLine($">Beans in stock: {coffeeShop.BeansInStockInKg}");
                    }
                    else
                    {
                        Console.WriteLine($"> Multiple commands found: ");
                        foreach (var coffeeType  in foundCoffeeShops)
                        {
                            Console.WriteLine($"> {coffeeType.Location}");
                        }

                    }
                }
            }
        }
    }
}
