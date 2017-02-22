using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace draciDoupe
{
    interface IAttack
    {
        
        //methods
        void Attack(Player p);
        void Attack(Creature c);
        void HeavyAttack(Creature c);
    }
}
