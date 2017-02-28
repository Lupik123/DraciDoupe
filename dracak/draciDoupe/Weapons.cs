using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace draciDoupe
{
    class Weapons
    {
        Random rnd = new Random();
        List<string> weaponName = new List<string>();
        Dictionary<string, int> weaponDamage = new Dictionary<string, int>();
        Dictionary<string, int> weaponDefense = new Dictionary<string, int>();

        public Weapons()
        {
            weaponName.Add("Sword");
            weaponName.Add("Longsword");
            weaponName.Add("Daggers");
            weaponName.Add("Battle Axe");
            weaponName.Add("Bow");

            weaponDamage.Add("Sword", 5);
            weaponDamage.Add("Longsword", 10);
            weaponDamage.Add("Daggers", 20);
            weaponDamage.Add("Battle Axe", 5);
            weaponDamage.Add("Bow", 20);

            weaponDefense.Add("Sword", 0);
            weaponDefense.Add("Longsword", 10);
            weaponDefense.Add("Daggers", -20);
            weaponDefense.Add("Battle Axe", 20);
            weaponDefense.Add("Bow", 0);
        }

        public string LootWeapon()
        {
            return weaponName[rnd.Next(weaponName.Count)];
        }

        public int GetWeaponDamage(string weapon)
        {
            return weaponDamage[weapon];
        }

        public int GetWeaponDefense(string weapon)
        {
            return weaponDefense[weapon];
        }


    }
}
