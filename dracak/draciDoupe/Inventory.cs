using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace draciDoupe
{
    class Inventory
    {
        List<string> inventory = new List<string>();

        public void AddToInventory(string item)
        {
            inventory.Add(item);
        }
    }
}
