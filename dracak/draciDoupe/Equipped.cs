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
        public List<int> hand = new List<int>();
        public List<int> hands = new List<int>();
        public List<int> rest = new List<int>();

        public void AddToEquipment(string item)
        {
            equipped.Add(item);
            int num = Game.item.GetItemPlace(item);

            if (num == 1)
            {
                if (hand.Count == 0)
                {
                    hand.Add(1);
                }

                else
                {
                    hand.Add(2);
                }
            }

            else if (num == 2)
            {
                hands.Add(1);
            }

            else if (num == 3)
            {
                Random rnd = new Random();
                rest.Add(rnd.Next());
            }
        }

        public void RemoveFromEquipment(string item)
        {
            equipped.Remove(item);
            int num = Game.item.GetItemPlace(item);

            if (num == 1)
            {
                hand.RemoveAt(hand.Count - 1);
            }

            else if (num == 2)
            {
                hands.RemoveAt(hands.Count - 1);
            }

            else if (num == 3)
            {
                rest.RemoveAt(rest.Count - 1);
            }
        }
    }
}
