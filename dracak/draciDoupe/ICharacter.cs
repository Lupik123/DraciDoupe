using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace draciDoupe
{
    interface ICharacter
    {
        string Name { get; set; }
        int HP { get; set; }
        int Damage { get; set; }
        bool CheckHP();
    }
}
