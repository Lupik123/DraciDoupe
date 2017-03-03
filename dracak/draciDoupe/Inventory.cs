using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace draciDoupe
{
    public class Inventory
    {
        public string Title { get; set; }
        public int Attack { get; set; }
        public int Defence { get; set; }

        public string item;

        public List<string> inventory = new List<string>();

        public void AddToInventory(string item)
        {
            inventory.Add(item);
        }
    }
}
