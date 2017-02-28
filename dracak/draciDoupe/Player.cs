using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace draciDoupe
{
    public class Player : IPlayer, IAttack, IDefence, ICharacter
    {
        public Player(string name, int maxHP, int level, int xp, int defence, int damage, int upgradePoints, int tolars)
        {
            _name = name;
            _hp = maxHP;
            _level = level;
            _xp = xp;
            _defence = defence;
            _damage = damage;
            _maxHP = maxHP;
            _upgradePoints = upgradePoints;
            _tolars = tolars;
        }
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
        private int _maxHP;
        public int MaxHP
        {
            get { return _maxHP; }
            set { _maxHP = value; }
        }
        private int _level;
        public int Level
        {
            get { return _level; }
            set { _level = value; }
        }
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _xp;
        public int XP
        {
           get { return _xp; }
           set { _xp = value; }
        }
        private int _defence;
        public int Defence
        {
            get { return _defence; }
            set { _defence = value; }
        }
        private int _upgradePoints;
        public int UpgradePoints
        {
            get { return _upgradePoints; }
            set { _upgradePoints = value; }
        }
        private int _tolars;
        public int Tolars
        {
            get { return _tolars; }
            set { _tolars = value; }
        }

        public void Attack(Player p)
        {

        }

        public void Attack(Creature c)
        {
            c.HP = c.HP - (_damage - (c.Defence / 10) * 3);
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

        public bool LevelUp()
        {        
            if (_xp == 3)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void RegenerateHP()
        {
            _hp = _maxHP;
        }

        public void HeavyAttack(Creature c)
        {
            Random rnd = new Random();
            int i;
            i = rnd.Next(1, 100);
            if (i <= 80) {
                c.HP = c.HP - ((_damage + _damage / 2));
            }
            else
            {
                
            }
        }
    }
}
