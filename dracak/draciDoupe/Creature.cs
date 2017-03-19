using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace draciDoupe
{
    public class Creature : IAttack, IDefence, ICharacter
    {
        Creatures creatureList = new Creatures();


        private int _damage;
        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }
        private int _hp;
        public int HP
        {
            get { return _hp; }
            set { _hp = value; }
        }
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private int _defence;
        public int Defence
        {
            get { return _defence; }
            set { _defence = value; }
        }

        public void GetCreature()
        {
            string creatureName = creatureList.Pick();
            _name = creatureName;

            if (Game.player.Level == 1)
            {
                _hp = creatureList.GetCreatureHealth(creatureName);
                _damage = creatureList.GetCreatureDamage(creatureName);
                _defence = creatureList.GetCreatureDefence(creatureName);
            }

            else if (Game.player.Level == 2)
            {              
                _hp = creatureList.GetCreatureHealth(creatureName) + 20;
                _damage = creatureList.GetCreatureDamage(creatureName) + 15;
                _defence = creatureList.GetCreatureDefence(creatureName) + 10;
            }

            else if (Game.player.Level == 3)
            {
                _hp = creatureList.GetCreatureHealth(creatureName) + 35;
                _damage = creatureList.GetCreatureDamage(creatureName) + 20;
                _defence = creatureList.GetCreatureDefence(creatureName) + 20;
            }

            else if (Game.player.Level == 4)
            {
                _hp = creatureList.GetCreatureHealth(creatureName) + 50;
                _damage = creatureList.GetCreatureDamage(creatureName) + 30;
                _defence = creatureList.GetCreatureDefence(creatureName) + 30;
            }

            else if (Game.player.Level == 5)
            {
                _hp = creatureList.GetCreatureHealth(creatureName) + 60;
                _damage = creatureList.GetCreatureDamage(creatureName) + 40;
                _defence = creatureList.GetCreatureDefence(creatureName) + 30;
            }

            else if (Game.player.Level == 6)
            {
                _hp = creatureList.GetCreatureHealth(creatureName) + 70;
                _damage = creatureList.GetCreatureDamage(creatureName) + 45;
                _defence = creatureList.GetCreatureDefence(creatureName) + 40;
            }

            else if (Game.player.Level == 7)
            {
                _hp = creatureList.GetCreatureHealth(creatureName) + 75;
                _damage = creatureList.GetCreatureDamage(creatureName) + 45;
                _defence = creatureList.GetCreatureDefence(creatureName) + 45;
            }

            else if (Game.player.Level == 8)
            {
                _hp = creatureList.GetCreatureHealth(creatureName) + 85;
                _damage = creatureList.GetCreatureDamage(creatureName) + 50;
                _defence = creatureList.GetCreatureDefence(creatureName) + 50;
            }

            else if (Game.player.Level == 9)
            {
                _hp = creatureList.GetCreatureHealth(creatureName) + 90;
                _damage = creatureList.GetCreatureDamage(creatureName) + 55;
                _defence = creatureList.GetCreatureDefence(creatureName) + 50;
            }

            else if (Game.player.Level == 10)
            {
                _hp = creatureList.GetCreatureHealth(creatureName) + 100;
                _damage = creatureList.GetCreatureDamage(creatureName) + 60;
                _defence = creatureList.GetCreatureDefence(creatureName) + 50;
            }
        }

        public string GetImage(string enemy)
        {
            return creatureList.GetCreatureImage(enemy);
        }

        public void Attack(Creature c)
        {
            throw new NotImplementedException();
        }

        public void Attack(Player p)
        {
            p.HP = p.HP - (_damage - (p.Defence / 10) * 3);
        }

        public bool CheckHP()
        {
            if (_hp <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void HeavyAttack(Creature c)
        {
            throw new NotImplementedException();
        }
    }
}
