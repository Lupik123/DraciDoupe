using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace draciDoupe
{
    interface IPlayer
    {
        int Level { get; set; }
        int XP { get; set; }
        int UpgradePoints { get; set; }
        bool LevelUp();
    }
}
