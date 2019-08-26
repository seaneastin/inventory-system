using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventorysystem
{
    class Defenseitem : Item
    {
        public int _defense;
        public int Defense
        {
            get
            {
                return _defense;
            }
        }
        public Defenseitem(string newName, int newDefense, int newWeight)
        {
            Name = newName;
            _defense = newDefense;
            weight = newWeight;
        }
    }
}
