using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyingInventory
{
    public class ShopItem
    {
        //Constructor that initializes a ShopItem object when a new ShopItem() is called/created.
        public string name;
        public int price;

        public ShopItem(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

    }




}
