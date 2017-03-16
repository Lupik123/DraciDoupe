using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace draciDoupe
{
    public class Equipped
    {
        public List<string> equipped = new List<string>();

        public void AddToEquipment(string item)
        {
            equipped.Add(item);
        }
    }
}
