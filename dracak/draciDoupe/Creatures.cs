using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace draciDoupe
{
    class Creatures
    {
        List<string> creatureList = new List<string>();
        Dictionary<string, int> creatureHP = new Dictionary<string, int>();
        Dictionary<string, int> creatureDefence = new Dictionary<string, int>();
        Dictionary<string, int> creatureDamage = new Dictionary<string, int>();
        Dictionary<string, string> creatureImage = new Dictionary<string, string>();
        Random rnd = new Random();

        public Creatures()
        {
            //Creature names
            creatureList.Add("Spider");
            creatureList.Add("Cyclop");
            creatureList.Add("Agressive Bat");
            creatureList.Add("Gremlin");


            //Creature HP
            creatureHP.Add("Spider", 150);
            creatureHP.Add("Cyclop", 180);
            creatureHP.Add("Agressive Bat", 80);
            creatureHP.Add("Gremlin", 130);


            //Creature defence
            creatureDefence.Add("Spider", 40);
            creatureDefence.Add("Cyclop", 10);
            creatureDefence.Add("Agressive Bat", 60);
            creatureDefence.Add("Gremlin", 50);

            
            //Creature damage
            creatureDamage.Add("Spider", rnd.Next(25, 41));
            creatureDamage.Add("Cyclop", rnd.Next(45, 66));
            creatureDamage.Add("Agressive Bat", rnd.Next(10, 21));
            creatureDamage.Add("Gremlin", rnd.Next(15, 31));


            //Creature image
            creatureImage.Add("Spider", "Images/spider.png");
            creatureImage.Add("Cyclop", "Images/cyclop.jpg");
            creatureImage.Add("Agressive Bat", "Images/bat.jpg");
            creatureImage.Add("Gremlin", "Images/gremlin.png");

        }
        // Method for random picking of a creature
        public string Pick()
        {
            return creatureList[rnd.Next(0, creatureList.Count)];
        }

        // Method for retrieving creature's health
        public int GetCreatureHealth(string creatureName)
        {
            return creatureHP[creatureName];
        }

        // Method for retrieving creature's defence
        public int GetCreatureDefence(string creatureName)
        {
            return creatureDefence[creatureName];
        }

        // Method for retrieving creature's damage
        public int GetCreatureDamage(string creatureName)
        {
            return creatureDamage[creatureName];
        }

        // Method for retrieving creature's image
        public string GetCreatureImage(string creatureName)
        {
            return creatureImage[creatureName];
        }
    }
}
