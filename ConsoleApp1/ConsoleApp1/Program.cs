using ClassLibrary.DataAccess;
using System;

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
            }
        }
    }
}
