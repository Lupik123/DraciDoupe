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

        public string GetCreature()
        {
            string creatureName = creatureList.Pick();
            _name = creatureName;
            _hp = creatureList.GetCreatureHealth(creatureName);
            _damage = creatureList.GetCreatureDamage(creatureName);
            _defence = creatureList.GetCreatureDefence(creatureName);
            return creatureName;
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
