using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace draciDoupe
{
    class Armor
    {
        Random rnd = new Random();
        List<string> armorType = new List<string>();
        Dictionary<string, int> armorDefense = new Dictionary<string, int>();

        public Armor()
        {
            armorType.Add("Helmet");
            armorType.Add("Chestguard");
            armorType.Add("Gauntlets");
            armorType.Add("Faulds");

            armorDefense.Add("Helmet", 10);
            armorDefense.Add("Chestguard", 20);
            armorDefense.Add("Gauntlets", 5);
            armorDefense.Add("Faulds", 10);
        }

        public string LootArmor()
        {
            return armorType[rnd.Next(armorType.Count)];
        }

        public int GetArmorDefense(string armor)
        {
            return armorDefense[armor];
        }
    }
}
