using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace draciDoupe
{
    public class Items
    {
        Random rnd = new Random();
        List<string> itemType = new List<string>();
        Dictionary<string, int> itemDamage = new Dictionary<string, int>();
        Dictionary<string, int> itemDefense = new Dictionary<string, int>();
        Dictionary<string, string> itemImage = new Dictionary<string, string>();

        public Items()
        {
            itemType.Add("Sword");
            itemType.Add("Longsword");
            itemType.Add("Daggers");
            itemType.Add("Battle Axe");
            itemType.Add("Bow");
            itemType.Add("Helmet");
            itemType.Add("Chestguard");
            itemType.Add("Gauntlets");
            itemType.Add("Shield");

            itemDamage.Add("Sword", 5);
            itemDamage.Add("Longsword", 10);
            itemDamage.Add("Daggers", 20);
            itemDamage.Add("Battle Axe", 10);
            itemDamage.Add("Bow", 20);
            itemDamage.Add("Helmet", 0);
            itemDamage.Add("Chestguard", 0);
            itemDamage.Add("Gauntlets", 0);
            itemDamage.Add("Shield", 5);

            itemDefense.Add("Sword", 0);
            itemDefense.Add("Longsword", 10);
            itemDefense.Add("Daggers", -20);
            itemDefense.Add("Battle Axe", 20);
            itemDefense.Add("Bow", 0);
            itemDefense.Add("Helmet", 10);
            itemDefense.Add("Chestguard", 20);
            itemDefense.Add("Gauntlets", 5);
            itemDefense.Add("Shield", 30);

            itemImage.Add("Sword", "Images/sword.jpg");
            itemImage.Add("Longsword", "Images/longsword.jpg");
            itemImage.Add("Daggers", "Images/daggers.jpg");
            itemImage.Add("Battle Axe", "Images/battleaxe.jpg");
            itemImage.Add("Bow", "Images/bow.jpg");
            itemImage.Add("Helmet", "Images/helmet.jpg");
            itemImage.Add("Chestguard", "Images/chestguard.jpg");
            itemImage.Add("Gauntlets", "Images/gauntlets.jpg");
            itemImage.Add("Shield", "Images/shield.jpg");
        }

        public string LootItem()
        {
            return itemType[rnd.Next(itemType.Count)];
        }

        public int GetItemDamage(string item)
        {
            return itemDamage[item];
        }

        public int GetItemDefense(string item)
        {
            return itemDefense[item];
        }

        public string GetItemImage(string item)
        {
            return itemImage[item];
        }
    }
}
