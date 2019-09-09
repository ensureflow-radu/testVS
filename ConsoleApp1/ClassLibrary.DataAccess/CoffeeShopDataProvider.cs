using ClassLibrary.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.DataAccess
{
    public class CoffeeShopDataProvider
    {
        public IEnumerable<CoffeeShop> LoadCoffessShops()
        {
            yield return new CoffeeShop { Location = "Frankfurt", BeansInStockInKg = 107 };
            yield return new CoffeeShop { Location = "Freiburg", BeansInStockInKg = 23 };
            yield return new CoffeeShop { Location = "Munich", BeansInStockInKg = 56};
        }
    }
}
