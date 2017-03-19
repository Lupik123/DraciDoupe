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
        public List<string> itemType = new List<string>();
        Dictionary<string, int> itemDamage = new Dictionary<string, int>();
        Dictionary<string, int> itemDefense = new Dictionary<string, int>();
        Dictionary<string, int> itemPlace = new Dictionary<string, int>();
        Dictionary<string, string> itemImage = new Dictionary<string, string>();
        Dictionary<string, int> itemPrice = new Dictionary<string, int>();

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
            itemDamage.Add("Bow", 0);
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

            itemPlace.Add("Sword", 1);
            itemPlace.Add("Longsword", 1);
            itemPlace.Add("Daggers", 2);
            itemPlace.Add("Battle Axe", 2);
            itemPlace.Add("Bow", 3);
            itemPlace.Add("Helmet", 3);
            itemPlace.Add("Chestguard", 3);
            itemPlace.Add("Gauntlets", 3);
            itemPlace.Add("Shield", 1);

            //Hand = 1, Hands = 2, Rest = 3

            itemPrice.Add("Sword", 10);
            itemPrice.Add("Longsword", 20);
            itemPrice.Add("Daggers", 30);
            itemPrice.Add("Battle Axe", 30);
            itemPrice.Add("Bow", 50);
            itemPrice.Add("Helmet", 10);
            itemPrice.Add("Chestguard", 20);
            itemPrice.Add("Gauntlets", 5);
            itemPrice.Add("Shield", 30);
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

        public int GetItemPlace(string item)
        {
            return itemPlace[item];
        }

        public int GetItemPrice(string item)
        {
            return itemPrice[item];
        }
    }
}
